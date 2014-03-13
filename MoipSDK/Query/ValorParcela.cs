namespace MoipSDK.Query
{
    /// <summary>
    /// Classe que representa uma opção de parcelamento.
    /// </summary>
    public class ValorParcela
    {
        /// <summary>
        /// Devolve o valor total pago pelo cliente através desta opção de parcelamento.
        /// </summary>
        public string Total { get; set; }
        /// <summary>
        /// Devolve os juros pagos através desta opção de parcelamento.
        /// </summary>
        public string Juros { get; set; }
        /// <summary>
        /// Devolve o valor por parcela pago através desta opção de parcelamento.
        /// </summary>
        public string Valor { get; set; }
        /// <summary>
        /// Devolve o número de parcelas pagas atraveś desta opção de parcelamento.
        /// </summary>
        public string Parcela { get; set; }
    }
}