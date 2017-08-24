using System.Collections.Generic;
using System.Linq;

namespace Cielo4NetApi.Services
{
    public class ServiceResponse<TResponse>
    {
        public ServiceResponse()
        {
        }

        public ServiceResponse(TResponse response, IList<ServiceError> errors)
        {
            Response = response;
            Errors = errors;
        }

        public TResponse Response { get; }
        public IList<ServiceError> Errors { get; }
        public bool HasErrors => Errors.Any();
    }
}