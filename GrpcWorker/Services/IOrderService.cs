using GrpcWorker.Dto;
using Qlua.Structs;

namespace GrpcWorker.Services;

public interface IOrderService
{
    void Buy(OrderDto order);
    
    void Sell(OrderDto order);

    Order GetOrder(long orderId, string classCode);

    void DeclineOrder(long orderId, string ticker, string classCode);
}