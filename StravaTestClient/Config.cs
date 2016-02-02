namespace StravaTestClient
{
    public class Config : Utilities.IConfig
    {
        public string Fullpath { get; set; }

        public string Token { get; set; }

        public string AuthCode { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string Version
        {
            get { return "1.0"; }
        }

        public void CreateDefaultConfig()
        {
            this.ClientId = "<client-id>";
            this.ClientSecret = "<client-secret>";
        }
    }
}