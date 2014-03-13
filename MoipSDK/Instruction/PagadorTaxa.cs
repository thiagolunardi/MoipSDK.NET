namespace MoipSDK.Instruction
{
    /// <summary>
    /// Nodo que define o pagador da taxa Moip.
    /// </summary>
    public class PagadorTaxa
    {
        /// <summary>
        /// Login Moip de um dos recebedores secundários que irá arcar com as taxas Moip utilizando o valor recebido na transação.
        /// </summary>
        public string LoginMoIP { get; set; }
    }
}
