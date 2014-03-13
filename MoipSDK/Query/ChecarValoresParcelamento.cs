using System;
using MoipSDK.Exception;

namespace MoipSDK.Query
{
    /// <summary>
    /// Classe usada para efetuar uma consulta de parcelamento no Moip.
    /// </summary>
    public class ChecarValoresParcelamento
    {
        public string Login { get; set; }
        public string MaxParcelas { get; set; }
        public string Juros { get; set; }
        public string Valor { get; set; }

        public void Validar()
        {
            var campos = String.Empty;
            if (String.IsNullOrEmpty(Login)) campos += "Moip login,";
            if (String.IsNullOrEmpty(MaxParcelas)) campos += "max parcels,";
            if (String.IsNullOrEmpty(Juros)) campos += "interest,";
            if (String.IsNullOrEmpty(Valor)) campos += "value,";


            if (!String.IsNullOrEmpty(campos))
                throw new ValidacaoDeInstrucaoException("Deve-se informar: " + campos.Substring(0, campos.Length - 1));
        }

        /// <summary>
        /// Devolve o caminho para onde esta instrução será mandada no Moip.
        /// </summary>
        public string Path
        {
            get { return "/ChecarValoresParcelamento"; }
        }
    }
}