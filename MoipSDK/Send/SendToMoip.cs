using System;
using System.Xml;
using System.Xml.Serialization;
using MoipSDK.Instruction;
using MoipSDK.Response;
using System.IO;
using System.Net;
using System.Text;

namespace MoipSDK.Send
{
    public abstract class SendToMoip
    {
        private readonly string _token;
        private readonly string _key;

        /// <summary>
        /// Cria um enviador com token e chave definidos.
        /// </summary>
        /// <param name="token">Define o token usado na autenticação.</param>
        /// <param name="key">Define a chave usada na autenticação.</param>
        protected SendToMoip(string token, string key)
        {
            _token = token;
            _key = key;
        }

        /// <summary>
        /// Define para qual ambiente os requests serão enviados.
        /// </summary>
        /// <returns></returns>
        public abstract string GetAmbiente();

        /// <summary>
        /// Cria o header de autorização para o método passado como parâmetro.
        /// </summary>
        /// <param name="webRequest"></param>
        private void CreateAuthHeader(WebRequest webRequest)
        {
            var authHeader = _token + ":" + _key;
            var hash = Convert.ToBase64String(Encoding.UTF8.GetBytes(authHeader));
            var encoded = "Basic " + hash;

            webRequest.Headers.Set(HttpRequestHeader.Authorization, encoded);
            webRequest.PreAuthenticate = true;
        }

        /// <summary>
        /// Envia uma instrução para o ambiente definido por este enviador.
        /// </summary>
        /// <param name="instrucaoRequest">Instrução Moip a ser enviada.</param>
        /// <returns></returns>
        public EnviarInstrucaoUnicaResponse Enviar(EnviarInstrucaoRequest instrucaoRequest)
        {
            instrucaoRequest.Validar();

            var responseBody = GetResponseBody(instrucaoRequest);

            var xr = XmlReader.Create(new StringReader(responseBody));
            var xs = new XmlSerializer(typeof(EnviarInstrucaoUnicaResponse));
            var response = (EnviarInstrucaoUnicaResponse) xs.Deserialize(xr);

            return response;
        }

        private string GetResponseBody(EnviarInstrucaoRequest instrucaoRequest)
        {
            var responseFromServer = String.Empty;
            // Create a request using a URL that can receive a post. 
            var request = WebRequest.Create(GetAmbiente() + instrucaoRequest.Path);
            // Set the Authorization header
            CreateAuthHeader(request);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            var postData = instrucaoRequest.GetXml();
            var byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            var dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            var response = request.GetResponse();
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            if (dataStream != null)
            {
                var reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
            }
            response.Close();

            return responseFromServer;
        }
    }
}