namespace Cielo4NetApi
{
    public class PaymentReturn
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Code}-{Name} ({Message})";
        }
    }
}