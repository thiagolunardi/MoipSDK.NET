namespace MoipSDK.Send
{
    public class ProducaoMoip : SendToMoip
    {
        public ProducaoMoip(string token, string key)
            : base(token, key)
        {
        }

        public override string GetAmbiente()
        {
            return "https://www.moip.com.br/ws/alpha";
        }
    }
}
