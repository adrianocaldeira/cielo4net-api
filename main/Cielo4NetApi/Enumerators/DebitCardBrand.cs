using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Bandeira para cart�o de d�bito
    /// </summary>
    public enum DebitCardBrand
    {
        /// <summary>
        ///     Visa
        /// </summary>
        [EnumMember(Value = "Visa")]
        Visa,

        /// <summary>
        ///     Master
        /// </summary>
        [EnumMember(Value = "Master")]
        Master
    }
}