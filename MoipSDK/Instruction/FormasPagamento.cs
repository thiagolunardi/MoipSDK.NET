namespace MoipSDK.Instruction
{
    public static class FormasPagamento
    {
        /// <summary>
        /// Boleto bancário impresso
        /// </summary>
        public static string BoletoBancario = "BoletoBancario";
        /// <summary>
        /// Cartão de crédito
        /// </summary>
        public static string CartaoDeCredito = "CartaoDeCredito";
        /// <summary>
        /// Cartão de crédito (usado apenas na InstrucaoUnica)
        /// </summary>
        public static string CartaoCredito = "CartaoCredito";
        /// <summary>
        /// Débito em conta no domicilio bancário do pagador
        /// </summary>
        public static string DebitoBancario = "DebitoBancario";
        /// <summary>
        /// Cartão de débito Visa Electron (apenas para correntistas do Bradesco)
        /// </summary>
        public static string CartaoDeDebito = "CartaoDeDebito";
        /// <summary>
        /// Cartão de débito Visa Electron (usado apenas na InstrucaoUnica)
        /// </summary>
        public static string CartaoDebito = "CartaoDebito";
        /// <summary>
        /// Financiamento obtido junto a instituição bancário do pagador.
        /// </summary>
        public static string FinanciamentoBancario = "FinanciamentoBancario";
        /// <summary>
        /// Diretamente da Carteira Moip do pagador 
        /// </summary>
        public static string CarteiraMoIP = "CarteiraMoIP";
    }
}
