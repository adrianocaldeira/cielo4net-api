using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    public enum Provider
    {
        [EnumMember(Value = "Bradesco")]
        Bradesco,
        [EnumMember(Value = "BancoDoBrasil")]
        BancoDoBrasil,
        [EnumMember(Value = "Simulado")]
        Simulado,
        [EnumMember(Value = "Cielo")]
        Cielo
    }
}