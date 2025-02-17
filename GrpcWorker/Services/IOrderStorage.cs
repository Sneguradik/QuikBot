using Qlua.Structs;

namespace GrpcWorker.Services;

public interface IOrderStorage
{
    public List<Order> Orders { get; set; }
}