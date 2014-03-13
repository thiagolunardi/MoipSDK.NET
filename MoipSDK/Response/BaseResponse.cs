using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MoipSDK.Response
{
    public class BaseResponse
    {
        public string ID { get; set; }
        public string Status { get; set; }

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
    }

    public static class ResponseStatus
    {
        public static string Sucesso = "Sucesso";
        public static string Falha = "Falha";
    }


}
