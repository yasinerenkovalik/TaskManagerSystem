using TaskManagerSystem.Application.Wrapper;
using TaskManagerSystem.Domain;

namespace Applicatino.Wrapper
{
    public class ErrorResponse<T> : BaseResponse<T> 
    {
        public int ErrorCode { get; set; }

        public ErrorResponse(int errorCode, string message)
            : base(false, message, default)
        {
            ErrorCode = errorCode;
        }
    }
}
