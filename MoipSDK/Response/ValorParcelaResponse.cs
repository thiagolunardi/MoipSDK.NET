using System.Collections.Generic;
using MoipSDK.Query;

namespace MoipSDK.Response
{
    /// <summary>
    /// Classe que representa a resposta do cálculo de parcelamento.
    /// </summary>
    public class ValorParcelaResponse : BaseResponse
    {
        /// <summary>
        /// Devolve a lista de opções de parcelamento, ou null se houveram erros.
        /// </summary>
        public List<ValorParcela> ValorDaParcela { get; set; }
        /// <summary>
        /// Devolve a lista de erros, ou null se não houveram.
        /// </summary>
        public List<Erro> Erros { get; set; }
    }
}
