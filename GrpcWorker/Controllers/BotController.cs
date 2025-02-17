using GrpcWorker.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GrpcWorker.Controllers;

[Route("bot")]
[ApiController]
public class BotController(IOptions<TradingDto> tradingOptions) : ControllerBase
{
    [HttpGet("current_config")]
    public TradingDto CurrentConfig() => tradingOptions.Value;

    [HttpPut("add_ticker")]
    public IActionResult AddTicker([FromBody]ClassTickerDto dto)
    {
        if (tradingOptions.Value
            .ClassesTradingDtos
            .Where(x=>x.ClassName==dto.ClassName)
            .Any(x=>x.Tickers.Contains(dto.Ticker))) return Ok("Already added");

        if (tradingOptions.Value.ClassesTradingDtos.Any(x => x.ClassName != dto.ClassName))
        {
            tradingOptions.Value.ClassesTradingDtos.Add(new ClassesTradingDto(dto.ClassName, [dto.Ticker]));
            return Ok("Added");
        }
            
        var classObject = tradingOptions.Value.ClassesTradingDtos
            .First(x => x.ClassName == dto.ClassName);
        classObject.Tickers.Add(dto.Ticker);
        return Ok("Added");
    }
}