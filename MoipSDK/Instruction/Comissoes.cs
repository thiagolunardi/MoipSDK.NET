using System;

namespace MoipSDK.Instruction
{
    /// <summary>
    /// Nodo com configurações de comissionamento(recebedor secundário).
    /// </summary>
    public class Comissoes
    {
        /// <summary>
        /// Nodo inicial para definições das comissões.
        /// </summary>
        public Comissionamento Comissionamento { get; set; }
        /// <summary>
        /// Nodo que define o pagador da taxa Moip.
        /// </summary>
        public PagadorTaxa PagadorTaxa { get; set; }
    }
}
