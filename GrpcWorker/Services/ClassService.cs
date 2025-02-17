
using Google.Protobuf;
using Qlua.Rpc.RPC;
using MarketGlass = Qlua.Rpc.GetQuoteLevel2.Result;
using ClassesList = Qlua.Rpc.GetClassesList.Result;
using MarketGlassArgs = Qlua.Rpc.GetQuoteLevel2.Args;
using ClassSecurities = Qlua.Rpc.GetClassSecurities.Result;
using ClassSecuritiesArgs = Qlua.Rpc.GetClassSecurities.Args;

namespace GrpcWorker.Services;

public class ClassService(ISocketService socketService) : IClassService
{
    public MarketGlass GetMarketGlass(string ticker, string classCode)
    {
        var args = new MarketGlassArgs()
        {
            SecCode = ticker,
            ClassCode = classCode
        };
        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.GetQuoteLevel2,
            Args = args.ToByteString()
        });
        var glass = new MarketGlass();
        glass.MergeFrom(resp.Result);
        return glass;
    }

    public ClassesList GetClassesList()
    {
        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.GetClassesList,
        });
        var classesList = new ClassesList();
        classesList.MergeFrom(resp.Result);
        return classesList;
    }

    public ClassSecurities GetClassSecurities(string classCode)
    {
        var args = new ClassSecuritiesArgs() { ClassCode = classCode };
        var resp = socketService.SendRequest(new Request()
        {
            Type = ProcedureType.GetClassSecurities,
            Args = args.ToByteString()
        });
        var classSecurities = new ClassSecurities();
        classSecurities.MergeFrom(resp.Result);
        return classSecurities;
    }
}