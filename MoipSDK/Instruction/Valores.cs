using System.Xml.Serialization;

namespace MoipSDK.Instruction
{
    /// <summary>
    /// Node com configurações de valores de um pagamento
    /// </summary>
    public class Valores
    {
        /// <summary>
        /// Valor a ser pago (caso mais de um seja enviado, o pagador escolhe o valor a ser pago)
        /// </summary>
        public double Valor { get; set; }
        /// <summary>
        /// Valor a ser acrescido ao montante a ser pago.
        /// </summary>
        public decimal Acrescimo { get; set; }
        /// <summary>
        /// Valor a ser deduzido do montante a ser pago.
        /// </summary>
        public decimal Deducao { get; set; }
        /// <summary>
        /// Atributo adicional que define o tipo de moeda.
        /// </summary>
        [XmlAttribute]
        public string Moeda { get; set; }
    }
}
