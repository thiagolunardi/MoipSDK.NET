namespace MoipSDK.Instruction
{
    /// <summary>
    /// Nodo inicial para definições das comissões
    /// </summary>
    public class Comissionamento
    {
        /// <summary>
        /// Nodo para definição será o recebedor secundário.
        /// </summary>
        public Comissionado Comissionado { get; set; }
        /// <summary>
        /// Valor percentual ao total pago que o recebedor secundário irá receber após conclusão de pagamento
        /// </summary>
        public decimal ValorPercentual { get; set; }
        /// <summary>
        /// Valor fixo que o recebedor secundário irá receber após conclusão de pagamento.
        /// </summary>
        public decimal ValorFixo { get; set; }
        /// <summary>
        /// Motivo ao qual o recebedor secundário está recebendo o valor.
        /// </summary>
        public string Razao { get; set; }
    }
}
