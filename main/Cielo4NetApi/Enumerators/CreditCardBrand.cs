using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Bandeira para cart�o de cr�dito
    /// </summary>
    public enum CreditCardBrand
    {
        [EnumMember(Value = "Visa")]
        Visa,
        [EnumMember(Value = "Master")]
        Master,
        [EnumMember(Value = "Amex")]
        Amex,
        [EnumMember(Value = "Elo")]
        Elo,
        [EnumMember(Value = "Aura")]
        Aura,
        [EnumMember(Value = "JCB")]
        JCB,
        [EnumMember(Value = "Diners")]
        Diners,
        [EnumMember(Value = "Discover")]
        Discover
    }
}