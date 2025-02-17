namespace GrpcWorker.Dto;

public class TradingDto
{
    public List<ClassesTradingDto> ClassesTradingDtos { get; set; } = new();
};

public class ClassesTradingDto
{
    public string ClassName {get; set;}
    public List<string> Tickers {get; set;} = new();
}

public record ClassTickerDto(string ClassName, string Ticker);