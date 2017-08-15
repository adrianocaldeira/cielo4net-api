namespace Cielo4NetApi
{
    /// <summary>
    ///     Ambiente
    /// </summary>
    public class Environment
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Environment" />
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="apiQueryUrl"></param>
        public Environment(string apiUrl, string apiQueryUrl)
        {
            ApiUrl = apiUrl;
            ApiQueryUrl = apiQueryUrl;
        }

        /// <summary>
        ///     URL da API
        /// </summary>
        public string ApiUrl { get; }

        /// <summary>
        ///     URL de consulta da API
        /// </summary>
        public string ApiQueryUrl { get; }

        /// <summary>
        ///     Ambiente de teste
        /// </summary>
        /// <returns></returns>
        public static Environment Sandbox()
        {
            return new Environment("https://apisandbox.cieloecommerce.cielo.com.br/",
                "https://apiquerysandbox.cieloecommerce.cielo.com.br/");
        }

        /// <summary>
        ///     Ambiente de produção
        /// </summary>
        /// <returns></returns>
        public static Environment Production()
        {
            return new Environment("https://api.cieloecommerce.cielo.com.br/",
                "https://apiquery.cieloecommerce.cielo.com.br/");
        }
    }
}