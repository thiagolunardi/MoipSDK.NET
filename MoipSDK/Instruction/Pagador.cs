namespace MoipSDK.Instruction
{
    /// <summary>
    /// Node com informações do pagador
    /// </summary>
    public class Pagador
    {
        /// <summary>
        /// Nome do pagador
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Login Moip do pagador
        /// </summary>
        public string LoginMoIP { get; set; }
        /// <summary>
        /// Seu id único de identificação do pagador
        /// </summary>
        public string IdPagador { get; set; }
        /// <summary>
        /// E-mail do pagador
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telefone celular do pagador, no formato (XX)XXXX-XXXX ou XXXXXXXXXX
        /// </summary>
        public string TelefoneCelular { get; set; }
        /// <summary>
        /// Apelido do pagador
        /// </summary>
        public string Apelido { get; set; }
        /// <summary>
        /// Identidade do pagador podendo ser CPF ou CNPJ do mesmo
        /// </summary>
        public string Identidade { get; set; }
        /// <summary>
        /// Node com informações do endereço de cobrança
        /// </summary>
        public Endereco EnderecoCobranca { get; set; }
        /// <summary>
        /// Node com informações do endereço de entrega
        /// </summary>
        public Endereco EnderecoEntrega { get; set; }
    }
}
