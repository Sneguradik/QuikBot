namespace GrpcWorker.Dto;

public record OrderDto(string Ticker, string ClassCode, double Price, int Quantity);
public record DeclineOrderDto(long OrderId, string Ticker, string ClassCode);