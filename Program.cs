using ReadSecretsConsole;

namespace WetterAppDL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var secretAppsettingReader = new SecretAppsettingReader();
            //https://www.programmingwithwolfgang.com/use-net-secrets-in-console-application/
            var geheim = secretAppsettingReader.ReadSection<SecretValues>("MySecretValues");
            OpenWeatherMapResponseParser parser = new OpenWeatherMapResponseParser();
            OpenWeatherMapClient client = new OpenWeatherMapClient(geheim
            .APP_ID, parser);
            WetterConsole console = new WetterConsole(client);
            console.start();
        }
    }
}

