using System.Text;
using Google.Protobuf;
using GrpcWorker.Handlers;
using GrpcWorker.Services;
using MassTransit;
using Models.MessageContract;
using NetMQ;
using NetMQ.Sockets;
using Qlua.Events;
using Qlua.Structs;

namespace GrpcWorker;

public class Worker(ILogger<Worker> logger, ISocketService socketService, IBus bus) : BackgroundService
{
    private readonly SubscriberSocket _client = socketService.CreateSubscribeSocket();
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _client.Subscribe("");
        await Task.Run(()=>RunSubscriber(stoppingToken),stoppingToken);
    }

    private Task RunSubscriber(CancellationToken stoppingToken)
    {
        var messageParts = new List<byte[]>();
        while (!stoppingToken.IsCancellationRequested)
        {
            
            if (_client.TryReceiveMultipartBytes(ref messageParts) &&
                messageParts.Count == 2)
            {
                byte[] messageCode = messageParts[0];
                byte[] messageBody = messageParts[1];
                
                int code = Convert.ToInt32(Encoding.UTF8.GetString(messageCode));
                bus.Publish(new EventMessage((EventType)code, DateTime.UtcNow, messageBody), stoppingToken);
            }
        }
        return Task.CompletedTask;
    }

    public override void Dispose()
    {
        _client.Dispose();
        base.Dispose();
    }
}