namespace Cielo4NetApi
{
    /// <summary>
    ///     Interface de ambiente
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        ///     URL da API
        /// </summary>
        string ApiUrl { get;  }

        /// <summary>
        ///     URL de consulta da API
        /// </summary>
        string ApiQueryUrl { get;  }
    }
}