using System;

namespace Cielo4NetApi.Request
{
    public class CieloRequestException : Exception
    {
        public CieloRequestException(int code, string message) : base(message)
        {
            Error = new CieloError(code, message);
        }

        public CieloRequestException(CieloError error)
        {
            Error = error;
        }

        public CieloError Error { get; }
    }
}