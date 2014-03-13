namespace MoipSDK.Exception
{
    public class MoipClientException : System.Exception
    {
        private int _statusCode = 200;

        public MoipClientException()
        { 
        }

        public MoipClientException(int statusCode, object causa)
        {
            _statusCode = statusCode;
        }

        /// <summary>
        /// Devolve o status HTTP obtido na comunicação com o Moip.
        /// </summary>
        /// <returns>Status Code</returns>
        public int GetStatusCode()
        {
            return _statusCode;
        }
    }
}