using System.Collections.Generic;
using System.Xml.Serialization;

namespace MoipSDK.Response
{
    /// <summary>
    /// Classe que representa a resposta ao cadastro de instrução.
    /// </summary>
    public class EnviarInstrucaoResponse : BaseResponse
    {
        /// <summary>
        /// Devolve o token associado à instrução cadastrada, ou null se houveram erros.
        /// </summary>
        [XmlIgnore]
        public string Token { get; set; }
     
        [XmlIgnore]
        private List<Erro> _erros;

        /// <summary>
        /// Devolve os erros, ou null se não houveram.
        /// </summary>
        
        [XmlElement("Erro")]
        public List<Erro> Erros
        {
            get { return _erros; }
            set { _erros = value; }
        }

        public override string ToString()
        {
            return "Resposta [id=" + ID + ", status=" + Status + ", token=" + Token+ ", erro=" + Erros + "]";
        }
    }
}
