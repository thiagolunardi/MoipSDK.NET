using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MoipSDK.Instruction
{
    public class EnviarInstrucaoRequest
    {
        internal EnviarInstrucaoRequest()
        {
        }

        public InstrucaoUnica InstrucaoUnica { get; set; }

        /// <summary>
        /// Define a instrução única a ser enviada com esta instrução.
        /// </summary>
        /// <param name="instrucaoUnica">Instrução única a ser enviada com esta instrução.</param>
        public EnviarInstrucaoRequest(InstrucaoUnica instrucaoUnica)
        {
            if (instrucaoUnica == null) throw new ArgumentNullException("instrucaoUnica");
            InstrucaoUnica = instrucaoUnica;
        }

        /// <summary>
        /// Valida esta instrução, lançando uma exceção que lista os campos faltantes. Esta validação sempre é invocada antes da instrução ser enviada.
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            return InstrucaoUnica.Validar();
        }

        /// <summary>
        /// Caminho para onde esta instrução será mandada no Moip.
        /// </summary>
        public string Path
        {
            get { return "/EnviarInstrucao/Unica"; }
        }

        /// <summary>
        /// Devolve o XML que esta instrução gera. 
        /// </summary>
        /// <returns></returns>
        public string GetXml()
        {
            var xs = new XmlSerializer(typeof(EnviarInstrucaoRequest));
            var ms = new MemoryStream();
            xs.Serialize(ms, this);
            var xml = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return xml;
        }

        public override string ToString()
        {
            return GetXml();
        }
    }
}