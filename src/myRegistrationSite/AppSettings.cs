using Microsoft.Framework.ConfigurationModel;

namespace myRegistrationSite
{
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    public static class AppSettings
    {
        private static IConfiguration Config
        {
            get
            {
                return Startup.Configuration.GetSubKey("appSettings");
            }
        }
        public static string ClientValidationEnabled
        {
            //get { return ConfigurationManager.AppSettings["ClientValidationEnabled"]; }
            get { return Config["ClientValidationEnabled"]; }
        }

        public static class Smtp
        {
            public static string Credential
            {
                get {  return Config["smtp.credential"]; }
            }

            public static string From
            {
                get { return Config["smtp.from"]; }
            }

            public static string Network
            {
                get { return Config["smtp.network"]; }
            }
        }

        public static string UnobtrusiveJavaScriptEnabled
        {
            get { return Config["UnobtrusiveJavaScriptEnabled"]; }
        }

        public static class Webpages
        {
            public static string Enabled
            {
                get { return Config["webpages:Enabled"]; }
            }

            public static string Version
            {
                get { return Config["webpages:Version"]; }
            }
        }
    }
}

