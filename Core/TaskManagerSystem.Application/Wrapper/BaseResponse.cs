using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Domain;

namespace TaskManagerSystem.Application.Wrapper
{
    public abstract class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        protected BaseResponse(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
