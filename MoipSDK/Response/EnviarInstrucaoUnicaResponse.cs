using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MoipSDK.Response
{
    [XmlRoot(Namespace = "http://www.moip.com.br/ws/alpha/")]
    public class EnviarInstrucaoUnicaResponse
    {
        /// <summary>
        /// Devolve a resposta ao cadastro de instrução única.
        /// </summary>
        [XmlElement(Namespace = "")]
        public EnviarInstrucaoResponse Resposta { get; set; }

        /// <summary>
        /// Propriedade que devolve true se o request foi bem-sucedido.
        /// </summary>
        [XmlIgnore]
        public string Status
        {
            get { return Resposta == null ? ResponseStatus.Falha : Resposta.Status; }
        }

        /// <summary>
        /// Devolve o XML do qual esta resposta foi gerada.
        /// </summary>
        /// <returns></returns>
        public string GetXml()
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
