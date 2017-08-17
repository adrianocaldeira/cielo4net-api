using System.Collections.Generic;
using System.Linq;

namespace Cielo4NetApi.Request
{
    public class CieloEcommerceResponse<TResponse>
    {
        public CieloEcommerceResponse(TResponse response, IList<CieloError> errors)
        {
            Response = response;
            Errors = errors;
        }

        public TResponse Response { get; }
        public IList<CieloError> Errors { get; }
        public bool HasErrors => Errors.Any();
    }
}