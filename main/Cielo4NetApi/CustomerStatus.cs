using System.Runtime.Serialization;

namespace Cielo4NetApi
{
    /// <summary>
    ///     Status do comprador
    /// </summary>
    public enum CustomerStatus
    {
        /// <summary>
        ///     Novo
        /// </summary>
        [EnumMember(Value = "NEW")]
        New,

        /// <summary>
        ///     Existente
        /// </summary>
        [EnumMember(Value = "EXISTING")]
        Existing
    }
}