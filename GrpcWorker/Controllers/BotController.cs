using GrpcWorker.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GrpcWorker.Controllers;

[Route("bot")]
[ApiController]
public class BotController(IOptions<List<ClassesTradingDto>> tradingOptions) : ControllerBase
{
    [HttpGet("current_config")]
    public List<ClassesTradingDto> CurrentConfig() => tradingOptions.Value;

    [HttpPut("add_ticker")]
    public IActionResult AddTicker([FromBody]ClassTickerDto dto)
    {
        if (tradingOptions.Value
            .Where(x=>x.ClassName==dto.ClassName)
            .Any(x=>x.Tickers.Contains(dto.Ticker))) return Ok("Already added");

        if (tradingOptions.Value.Any(x => x.ClassName != dto.ClassName))
        {
            tradingOptions.Value.Add(new ClassesTradingDto{ClassName = dto.ClassName, Tickers = [dto.Ticker]});
            return Ok("Added");
        }
            
        var classObject = tradingOptions.Value
            .First(x => x.ClassName == dto.ClassName);
        classObject.Tickers.Add(dto.Ticker);
        return Ok("Added");
    }
}