namespace Cielo4NetApi
{
    /// <summary>
    ///     Comerciante
    /// </summary>
    public class Merchant
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Merchant" />
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        public Merchant(string id, string key)
        {
            Id = id;
            Key = key;
        }

        /// <summary>
        ///     Identificador da loja na Cielo
        /// </summary>
        public string Id { get; }

        /// <summary>
        ///     Chave Publica para Autenticação Dupla na Cielo.
        /// </summary>
        public string Key { get; }
    }
}