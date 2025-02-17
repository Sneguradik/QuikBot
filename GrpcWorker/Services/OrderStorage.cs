using Qlua.Structs;

namespace GrpcWorker.Services;

public class OrderStorage: IOrderStorage
{
    public List<Order> Orders { get; set; } = new ();
}