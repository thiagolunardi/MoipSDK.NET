namespace MoipSDK.Instruction
{
    /// <summary>
    /// Node com informações do endereço
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// Rua, Avenida e etc de onde se encontra o endereço.
        /// </summary>
        public string Logradouro { get; set; }
        /// <summary>
        /// Numero referente ao endereço.
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Complemento referente ao endereço.
        /// </summary>
        public string Complemento { get; set; }
        /// <summary>
        /// Bairro onde se encontra o endereço.
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// CEP, no formato XXXXX-XXX ou XXXXXXXX.
        /// </summary>
        public string CEP { get; set; }
        /// <summary>
        /// Cidade onde se encontra o endereço
        /// </summary>
        public string Cidade { get; set; }
        /// <summary>
        /// Código de duas letras referente ao estado (UF).
        /// </summary>
        public string Estado { get; set; }
        /// <summary>
        /// Código de três letras referente ao país.
        /// </summary>
        public string Pais { get; set; }
        /// <summary>
        /// Telefone, no formato (XX)XXXX-XXXX ou XXXXXXXXXX.
        /// </summary>
        public string TelefoneFixo { get; set; }
    }
}
