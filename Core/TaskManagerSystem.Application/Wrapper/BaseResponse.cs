using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Domain;

namespace TaskManagerSystem.Application.Wrapper
{
    public  class BaseResponse<T>
    {
        public BaseResponse(bool success, string message, T data, IEnumerable<string>? errorMessages)
        {
            Success = success;
            Message = message;
            Data = data;
            ErrorMessages = errorMessages;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public IEnumerable<string>? ErrorMessages { get; set; } = null;


        /*  public BaseResponse(bool success, string message, T data)
          {
              Success = success;
              Message = message;
              Data = data;
          }*/
    }
}
