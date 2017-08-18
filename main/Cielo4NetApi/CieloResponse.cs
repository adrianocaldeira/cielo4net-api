using System.Collections.Generic;
using System.Linq;

namespace Cielo4NetApi
{
    public class CieloResponse<TResponse>
    {
        public CieloResponse()
        {
        }

        public CieloResponse(TResponse response, IList<CieloError> errors)
        {
            Response = response;
            Errors = errors;
        }

        public TResponse Response { get; }
        public IList<CieloError> Errors { get; }
        public bool HasErrors => Errors.Any();
    }
}