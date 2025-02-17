namespace GrpcWorker.Dto;

public record TradingDto(List<ClassesTradingDto> ClassesTradingDtos);

public record ClassesTradingDto(string ClassName, List<string> Tickers);

public record ClassTickerDto(string ClassName, string Ticker);