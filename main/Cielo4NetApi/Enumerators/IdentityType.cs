using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    /// <summary>
    ///     Tipo de identifica��o do comprador
    /// </summary>
    public enum IdentityType
    {
        /// <summary>
        ///     CPF
        /// </summary>
        [EnumMember(Value = "CPF")]
        Cpf,

        /// <summary>
        ///     CNPJ
        /// </summary>
        [EnumMember(Value = "CNPJ")]
        Cnpj
    }
}