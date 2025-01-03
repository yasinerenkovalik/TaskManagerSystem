using TaskManagerSystem.Application.Wrapper;
using TaskManagerSystem.Domain;

namespace Applicatino.Wrapper
{
    public class SuccessResponse<T> : BaseResponse<T> 
    {
        public SuccessResponse(T data, string message)
            : base(true, message, data)
        {
        }
    }
}
