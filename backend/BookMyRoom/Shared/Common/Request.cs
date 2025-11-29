using ProtoBuf;

namespace Shared.Common;

[ProtoContract]
public class Request<T>
{
    [ProtoMember(1)]
    public T? Data { get; set; }

    public Request() {}

    public Request(T data)
    {
        Data = data;
    }
}