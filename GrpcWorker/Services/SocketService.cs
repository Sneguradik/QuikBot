using Google.Protobuf;
using GrpcWorker.Dto;
using Microsoft.Extensions.Options;
using NetMQ;
using NetMQ.Sockets;
using Qlua.Rpc.RPC;

namespace GrpcWorker.Services;

public class SocketService(IOptions<ConnectionDto> connectionOptions) : ISocketService
{
    private readonly ConnectionDto _connectionOptions = connectionOptions.Value;
    
    public RequestSocket CreateRequestSocket()
    {
        var socket = new RequestSocket();
        socket.Connect(_connectionOptions.RequestSocket);
        return socket;
    }

    public SubscriberSocket CreateSubscribeSocket()
    {
        var socket = new SubscriberSocket();
        socket.Connect(_connectionOptions.SubscribeSocket);
        return socket;
    }

    public Response SendRequest(Request request)
    {
        using var client = CreateRequestSocket();
        client.SendFrame(request.ToByteArray());
        var response = new Response();
        response.MergeFrom(client.ReceiveMultipartMessage().First.ToByteArray());
        return response;
    }
    
    
}