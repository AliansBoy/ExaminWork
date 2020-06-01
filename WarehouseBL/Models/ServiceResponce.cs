using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL.Models
{
    public class ServiceResponse
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public ServiceResponse() { }

        public ServiceResponse(bool isSuccessful)
        {
            IsSuccessful = isSuccessful;
            Message = string.Empty;
        }

        public ServiceResponse(bool isSuccessful, string message)
            : this(isSuccessful)
        {
            Message = message;
        }

        public ServiceResponse SetMessage(string message)
        {
            Message = message;
            return this;
        }
    }

    public class ServiceResponse<T> : ServiceResponse
    {
        public T ResponseObject { get; set; }

        public ServiceResponse() { }

        public ServiceResponse(bool isSuccessful) : base(isSuccessful) { }

        public ServiceResponse(bool isSuccessful, string message) : base(isSuccessful, message) { }

        public ServiceResponse(bool isSuccessful, string message, T responseObject)
            : base(isSuccessful, message)
        {
            ResponseObject = responseObject;
        }
    }
}
