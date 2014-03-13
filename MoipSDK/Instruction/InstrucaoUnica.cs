using System;
using System.Collections.Generic;
using MoipSDK.Exception;

namespace MoipSDK.Instruction
{
    /// <summary>
    /// Node raiz
    /// </summary>
    public class InstrucaoUnica
    {
        public TipoValidacao TipoValidacao { get; set; }

        /// <summary>
        /// Razão do envio da instrução de cobrança/pagamento.
        /// </summary>
        public string Razao { get; set; }

        /// <summary>
        /// Node com valores monetários relativos ao pagamento e acréscimos e deduções pertinentes.
        /// </summary>
        public Valores Valores { get; set; }

        /// <summary>
        /// Identificador próprio gerado pelo sistema do integrador que identifica a instrução no mesmo.
        /// </summary>
        public string IdProprio { get; set; }

        /// <summary>
        /// Node com lista de parcelamentos disponibilizados para o pagador para essa instrução.
        /// </summary>
        public List<Parcelamento> Parcelamentos { get; set; }

        /// <summary>
        /// Lista de comissões a serem dadas caso o pagamento seja concluído.
        /// </summary>
        public List<Comissoes> Comissoes { get; set; }

        /// <summary>
        /// Dados de quem irá receber o pagamento (tem que ter Carteira MoIP). Caso não seja enviado, o recebedor é o próprio integrador.
        /// </summary>
        public Recebedor Recebedor { get; set; }

        /// <summary>
        /// Dados de quem está pagando
        /// </summary>
        public Pagador Pagador { get; set; }

        /// <summary>
        /// Node com formas de pagamento a serem aceitas no momento do(s) pagamento(s) da instrução
        /// </summary>
        public string FormasPagamento { get; set; }

        /// <summary>
        /// Node com propriedades específicas para o pagamento por boleto bancário
        /// </summary>
        public Boleto Boleto { get; set; }

        /// <summary>
        /// Sobreescreve o URL padrão cadastrado na Carteira MoIP para retorno do usuário após o pagamento (1)
        /// </summary>
        public string URLRetorno { get; set; }

        /// <summary>
        /// Sobreescreve o URL padrão cadastrado na Carteira MoIP para envio das informações sobre alterações no status dos pagamentos (1)(2)
        /// </summary>
        public string UrlNotificacao { get; set; }


        /// <summary>
        /// Valida esta instrução, lançando uma exceção que lista os campos faltantes.
        /// </summary>
        public bool Validar()
        {
            var campos = "";
            if (String.IsNullOrEmpty(IdProprio)) campos += "IdProprio,";
            if (String.IsNullOrEmpty(Razao)) campos += "Razao,";
            if (Valores == null) campos += "Valores,";

            if (TipoValidacao == TipoValidacao.Transparente)
                campos += ValidacaoTransparente();


            if (!String.IsNullOrEmpty(campos))
                throw new ValidacaoDeInstrucaoException("Valores não informados: " +
                                                         campos.Substring(0, campos.Length - 1));
            return true;
        }

        private string ValidacaoTransparente()
        {
            var campos = "";
            if (Pagador == null) 
                campos += "payer,";
            else
            {
                if (String.IsNullOrEmpty(Pagador.Nome)) campos += "Nome,";
                if (String.IsNullOrEmpty(Pagador.Email)) campos += "Email,";
                if (String.IsNullOrEmpty(Pagador.IdPagador)) campos += "IdPagador,";
                if (Pagador.EnderecoCobranca == null) campos += "EnderecoCobranca,";
                else
                {
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Logradouro)) campos += "Logradouro,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Numero)) campos += "Numero,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Bairro)) campos += "Bairro,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Cidade)) campos += "Cidade,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Estado)) campos += "Estado,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.Pais)) campos += "Pais,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.CEP)) campos += "CEP,";
                    if (String.IsNullOrEmpty(Pagador.EnderecoCobranca.TelefoneFixo)) campos += "TelefoneFixo,";
                }
            }

            return campos;
        }
    }

    public enum TipoValidacao
    {
        Transparente,
        Simples
    }
}