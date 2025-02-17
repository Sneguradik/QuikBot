using GrpcWorker.Dto;
using GrpcWorker.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrpcWorker.Controllers;

[Route("order")]
[ApiController]
public class OrderController(IOrderService orderService) : ControllerBase
{
    [HttpPost("buy")]
    public IActionResult Buy([FromBody]OrderDto orderDto)
    {
        orderService.Buy(orderDto);
        return Ok("Transaction sent");
    }
    
    [HttpPost("sell")]
    public IActionResult Sell([FromBody]OrderDto orderDto)
    {
        orderService.Sell(orderDto);
        return Ok("Transaction sent");
    }
    
    [HttpPost("cancel")]
    public IActionResult Cancel([FromBody]DeclineOrderDto orderDto)
    {
        orderService.DeclineOrder(orderDto.OrderId, orderDto.Ticker, orderDto.ClassCode);
        return Ok("Transaction sent");
    }
    
}