using System.Globalization;
using Google.Protobuf;
using GrpcWorker.Dto;
using GrpcWorker.Services;
using MassTransit;
using Models.MessageContract;
using Qlua.Events;
using Qlua.Structs;

namespace GrpcWorker.Handlers;

public class MessageConsumer(ILogger<MessageConsumer> logger,IClassService classService, IOrderService orderService) 
    : IConsumer<EventMessage>
{
    public Task Consume(ConsumeContext<EventMessage> context)
    {
        //logger.LogInformation($"Received message: {context.Message.Type.ToString()}");
        switch (context.Message.Type)
        {
            case EventType.OnQuote:
                var eventData = new QuoteEventInfo();
                eventData.MergeFrom(context.Message.Message);
                ProcessQuoteEventInfo(eventData);
                break;
            default:
                logger.LogInformation($"Message passed");
                break;
        }
        return Task.CompletedTask;
    }

    private void ProcessQuoteEventInfo(QuoteEventInfo eventInfo)
    {
        var glass = classService.GetMarketGlass(eventInfo.SecCode, eventInfo.ClassCode);
        string info = $"Received quote message: {eventInfo.SecCode} {eventInfo.ClassCode}\n";
        var bidAmount = double.Parse(glass.BidCount, CultureInfo.InvariantCulture);
        var offerAmount = double.Parse(glass.OfferCount, CultureInfo.InvariantCulture);

        if (bidAmount>0)
        {
            var bestBid = glass.Bids.Last();
            info += $"Best bid (price,quantity): {bestBid.Price} {bestBid.Quantity}\n";
            var iterBids = bidAmount>5?5:bidAmount;
            for (int i = 0; i < iterBids; i++)
            {
                orderService.Buy(new OrderDto(
                    eventInfo.SecCode, 
                    eventInfo.ClassCode,
                    Convert.ToDouble(glass.Bids[(int)bidAmount - 1 - i].Price)*(100-i-1)/100, 1));
            }
        }

        if (offerAmount > 0)
        {
            var bestOffer = glass.Offers.First();
            info += $"Best offer (price,quantity): {bestOffer.Price} {bestOffer.Quantity}\n";
            var iterOffers = offerAmount>5?5:offerAmount;
            for (int i = 0; i < iterOffers; i++)
            {
                orderService.Sell(new OrderDto(
                    eventInfo.SecCode, 
                    eventInfo.ClassCode,
                    Convert.ToDouble(glass.Bids[i].Price)*(100+i+1)/100, 1));
            }
        }
        logger.LogInformation(info);
    }
    
}