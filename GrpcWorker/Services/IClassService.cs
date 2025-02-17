namespace GrpcWorker.Services;
using MarketGlass = Qlua.Rpc.GetQuoteLevel2.Result;
using ClassesList = Qlua.Rpc.GetClassesList.Result;
using ClassSecurities = Qlua.Rpc.GetClassSecurities.Result;

public interface IClassService
{
    MarketGlass GetMarketGlass(string ticker, string classCode);
    
    ClassesList GetClassesList();

    ClassSecurities GetClassSecurities(string classCode);
}