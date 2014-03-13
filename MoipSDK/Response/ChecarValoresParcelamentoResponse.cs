using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MoipSDK.Response
{
    public class ChecarValoresParcelamentoResponse : BaseResponse
    {
        /// <summary>
        /// Devolve a resposta do cálculo de parcelamento.
        /// </summary>
        public ValorParcelaResponse Response { get; set; }

        /// <summary>
        /// Propriedade que devolve true se o request foi bem-sucedido.
        /// </summary>
        public new string Status
        {
            get { return Response == null ? ResponseStatus.Falha : base.Status; }
        }

        /// <summary>
        /// Devolve o XML do qual esta resposta foi gerada.
        /// </summary>
        /// <returns></returns>
        public new string GetXml()
        {
            var xs = new XmlSerializer(GetType());
            var ms = new MemoryStream();
            xs.Serialize(ms, this);
            var xml = Encoding.UTF8.GetString(ms.ToArray());
            return xml;
        }

        public override string ToString()
        {
            return GetXml();
        }
    }
}
