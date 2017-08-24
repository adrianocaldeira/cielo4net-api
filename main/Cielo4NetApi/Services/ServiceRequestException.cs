using System;

namespace Cielo4NetApi.Services
{
    public class ServiceRequestException : Exception
    {
        public ServiceRequestException(int code, string message) : base(message)
        {
            Error = new ServiceError(code, message);
        }

        public ServiceRequestException(ServiceError error)
        {
            Error = error;
        }

        public ServiceError Error { get; }
    }
}