using ProtoBuf;

namespace Shared.Common;

[ProtoContract]
public class Response<T>
{
    [ProtoMember(1)]
    public StatusCode Status { get; set; }

    [ProtoMember(2)]
    public string? Message { get; set; }

    [ProtoMember(3)]
    public T? Data { get; set; }

    public Response() {}

    public Response(StatusCode status, string? message = null, T? data = default)
    {
        Status = status;
        Message = message;
        Data = data;
    }
    
    public static Response<T> SuccessResponse(T data, string message = "Success")
        => new Response<T>
        {
            Status = StatusCode.Success,
            Message = message,
            Data = data
        };

    public static Response<T> ErrorResponse(string message)
        => new Response<T>
        {
            Status = StatusCode.Error,
            Message = message,
            Data = default
        };
}