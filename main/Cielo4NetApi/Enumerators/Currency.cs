using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    public enum Currency
    {
        [EnumMember(Value = "BRL")]
        Brl,
        [EnumMember(Value = "USD")]
        Usd,
        [EnumMember(Value = "MXN")]
        Mxn,
        [EnumMember(Value = "COP")]
        Cop,
        [EnumMember(Value = "CLP")]
        Clp,
        [EnumMember(Value = "ARS")]
        Ars,
        [EnumMember(Value = "PEN")]
        Pen,
        [EnumMember(Value = "EUR")]
        Eur,
        [EnumMember(Value = "PYN")]
        Pyn,
        [EnumMember(Value = "UYU")]
        Uyu,
        [EnumMember(Value = "VEB")]
        Veb,
        [EnumMember(Value = "VEF")]
        Vef,
        [EnumMember(Value = "GBP")]
        Gbp
    }
}