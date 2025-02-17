using Google.Protobuf;
using Qlua.Events;

namespace Models.MessageContract;

public record EventMessage(EventType Type, DateTime ReceivedAt, byte[] Message);