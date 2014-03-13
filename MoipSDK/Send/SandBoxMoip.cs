namespace MoipSDK.Send
{
    public class SandBoxMoip : SendToMoip
    {
        public SandBoxMoip(string token, string key) : base(token, key)
        {
        }

        public override string GetAmbiente()
        {
            return "https://desenvolvedor.moip.com.br/sandbox/ws/alpha";
        }
    }
}
