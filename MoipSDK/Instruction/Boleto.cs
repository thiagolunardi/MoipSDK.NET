using System;

namespace MoipSDK.Instruction
{
    /// <summary>
    /// Nodo com definições a serem aplicadas em um boleto bancário.
    /// </summary>
    public class Boleto
    {
        /// <summary>
        /// Dias de expiração do boleto, depois de impresso. Com atributo “Tipo” (Corridos/Uteis).
        /// </summary>
        public int DiasExpiracao { get; set; }
        /// <summary>
        /// Data de vencimento fixa para o boleto.
        /// </summary>
        public DateTime DataVencimento { get; set; }
        /// <summary>
        /// Primeira linha de instrução para o boleto.
        /// </summary>
        public string Instrucao1 { get; set; }
        /// <summary>
        /// Segunda linha de instrução para o boleto.
        /// </summary>
        public string Instrucao2 { get; set; }
        /// <summary>
        /// Terceira linha de instrução para o boleto.
        /// </summary>
        public string Instrucao3 { get; set; }
        /// <summary>
        /// URL da imagem do logo a ser mostrado no boleto.
        /// </summary>
        public string URLLogo { get; set; }
    }
}
