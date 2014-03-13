namespace MoipSDK.Instruction
{
    /// <summary>
    /// Classe que representa uma regra de parcelamento.
    /// </summary>
    public class Parcelamento
    {
        /// <summary>
        /// Define o número mínimo de parcelas deste parcelamento.
        /// </summary>
        public int MinimoParcelas { get; set; }
        /// <summary>
        /// Define o número máximo de parcelas deste parcelamento.
        /// </summary>
        public int MaximoParcelas { get; set; }
        /// <summary>
        /// Define o tipo de recebimento deste parcelamento.
        /// </summary>
        public string Recebimento { get; set; }
        /// <summary>
        /// Define a taxa de juros deste parcelamento.
        /// </summary>
        public double Juros { get; set; }
        /// <summary>
        /// Define se os juros devem ser repassados pro cliente ou não.
        /// </summary>
        public bool Repassar { get; set; }

        public Parcelamento()
        {
        }
    }

    public static class TipoRecebimento
    {
        public static string AVista = "AVista";
        public static string Parcelado = "Parcelado";
    }
}
