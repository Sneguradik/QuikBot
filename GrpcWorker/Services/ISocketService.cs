using NetMQ.Sockets;
using Qlua.Rpc.RPC;

namespace GrpcWorker.Services;

public interface ISocketService
{
    public RequestSocket CreateRequestSocket();
    
    public SubscriberSocket CreateSubscribeSocket();

    Response SendRequest(Request request);
}