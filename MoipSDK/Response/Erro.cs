using System.Xml.Serialization;

namespace MoipSDK.Response
{
    public class Erro
    {
        [XmlAttribute]
        public string Codigo { get; set; }
        [XmlText]
        public string Mensagem { get; set; }
    }
}
