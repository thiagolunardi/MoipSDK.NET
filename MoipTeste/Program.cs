using System;
using System.Collections.Generic;
using MoipSDK.Instruction;
using MoipSDK.Send;

namespace MoipTeste
{
    class Program
    {
        private const string Token = "IZULDKTAUWJFODVDTCOXO012Y7FOGWPQ";
        private const string Key = "QUXHW74BPQASMIWCZQJC5IFLZNWODHKCILXLTLDF";

        static void Main(string[] args)
        {
            var enviarInstrucao = new EnviarInstrucaoRequest(
                (new InstrucaoUnica
                {
                    TipoValidacao = TipoValidacao.Transparente,
                    Razao = "Uma motivo pela compra",
                    IdProprio = Guid.NewGuid().ToString(),
                    Pagador = new Pagador
                    {
                        Nome = "Thiago Lunardi",
                        Email = "thiagolunardi@ucast.com.br",
                        IdPagador = "BRENOID",
                        Identidade = "222.222.222-22",
                        TelefoneCelular = "(12)9999-9999",
                        EnderecoCobranca = new Endereco
                        {
                            Logradouro = "Rua Vergueiro",
                            Numero = "853",
                            Bairro = "Vila Mariano",
                            CEP = "04600-021",
                            Cidade = "Sao Paulo",
                            Estado = "SP",
                            Pais = "BRA",
                            TelefoneFixo = "(22)2222-2222"
                        },
                    },
                    Boleto = new Boleto { DiasExpiracao = 5 },
                    Valores = new Valores { Valor = 15.00 },
                    Recebedor = new Recebedor
                    {
                        LoginMoIP = "gustavo@ucast.com.br",
                        Apelido = "Gustavo"
                    },
                    Parcelamentos = new List<Parcelamento>
                       {
                           new Parcelamento
                           {
                               MinimoParcelas = 1,
                               MaximoParcelas = 3,
                               Juros = 1.0,
                               Recebimento = TipoRecebimento.AVista,
                               Repassar = false
                           }
                       },
                    UrlNotificacao = "http://meu.site.com/nasp",
                    URLRetorno = "http://meu.site.com/retorno"
                }));

            Console.WriteLine(enviarInstrucao.GetXml());
            Console.WriteLine("--------------------------------");


            var response = new SandBoxMoip(Token, Key).Enviar(enviarInstrucao);

            Console.WriteLine(response.GetXml());

        }
    }
}
