using System.Runtime.Serialization;

namespace Cielo4NetApi.Enumerators
{
    public enum RecurrentPaymentInterval
    {
        /// <summary>
        ///     Mensal
        /// </summary>
        [EnumMember(Value = "Monthly")] Monthly = 1,

        /// <summary>
        ///     Bimestral
        /// </summary>
        [EnumMember(Value = "Bimonthly")] Bimonthly = 2,

        /// <summary>
        ///     Trimestral
        /// </summary>
        [EnumMember(Value = "Quarterly")] Quarterly = 3,

        /// <summary>
        ///     Semestral
        /// </summary>
        [EnumMember(Value = "SemiAnnual")] SemiAnnual = 6,

        /// <summary>
        ///     Anual
        /// </summary>
        [EnumMember(Value = "Annual")] Annual = 12
    }
}