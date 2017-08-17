namespace Cielo4NetApi
{
    public class CieloError
    {
        public CieloError(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; }
        public string Message { get; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Code}-{Message}";
        }
    }
}