using System.Globalization;
using System.Transactions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GrpcWorker.Dto;
using Microsoft.Extensions.Options;
using Qlua.Rpc.RPC;
using Qlua.Structs;
using Transaction = System.Transactions.Transaction;
using GetOrderByNumberArgs = Qlua.Rpc.GetOrderByNumber.Args;
using GetOrderByNumberResult = Qlua.Rpc.GetOrderByNumber.Result;
using TransactionArgs = Qlua.Rpc.SendTransaction.Args;
using TransactionResult = Qlua.Rpc.SendTransaction.Result;

namespace GrpcWorker.Services;


public class OrderService(ISocketService socketService, IOptions<TradingAccount> tradingAccount) : IOrderService
{
    public void Buy(OrderDto order)
    {
        var result = PlaceOrder(order, "B");
        Console.WriteLine(result.Result_);
    }

    public void Sell(OrderDto order)
    {
        var result = PlaceOrder(order, "S");
        Console.WriteLine(result.Result_);
    }

    public Order GetOrder(long orderId, string classCode)
    {
        var args = new GetOrderByNumberArgs()
        {
            ClassCode = classCode,
            OrderId = orderId
        };
        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.GetOrderByNumber,
            Args = args.ToByteString()
        });
        var res = new GetOrderByNumberResult();
        res.MergeFrom(resp.Result);
        return res.Order;
    }

    public void DeclineOrder(long orderId, string ticker, string classCode)
    {
        var args = new TransactionArgs();
        args.Transaction.Add("ACTION", "KILL_ORDER");
        args.Transaction.Add("CLASSCODE", classCode);
        args.Transaction.Add("SECCODE", ticker);
        args.Transaction.Add("ORDER_KEY", orderId.ToString());

        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.SendTransaction,
            Args = args.ToByteString(),
        });

        var result = new TransactionResult();
        result.MergeFrom(resp.Result);
    }


    private TransactionResult PlaceOrder(OrderDto order, string operationType)
    {
        var args = new TransactionArgs();
        args.Transaction.Add("ACTION", "NEW_ORDER");
        args.Transaction.Add("CLASSCODE", order.ClassCode);
        args.Transaction.Add("SECCODE", order.Ticker);
        args.Transaction.Add("OPERATION", operationType);
        args.Transaction.Add("PRICE", order.Price.ToString(CultureInfo.InvariantCulture));
        args.Transaction.Add("QUANTITY", order.Quantity.ToString());
        args.Transaction.Add("ACCOUNT", tradingAccount.Value.Account);
        args.Transaction.Add("CLIENT_CODE", tradingAccount.Value.ClientCode);
        args.Transaction.Add("TYPE", "L");
        args.Transaction.Add("TRANS_ID", "1");

        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.SendTransaction,
            Args = args.ToByteString(),
        });

        var result = new TransactionResult();
        result.MergeFrom(resp.Result);
        return result;
    }
}