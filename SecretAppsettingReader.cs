using Microsoft.Extensions.Configuration;

namespace ReadSecretsConsole;

public class SecretAppsettingReader
{
    public T ReadSection<T>(string sectionName)
    {
        // var environment = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
        var builder = new ConfigurationBuilder()
            .AddJsonFile("C:/Users/diete/AppData/Roaming/Microsoft/UserSecrets/d87b0f3c-4538-4621-afd9-7c5dd0b3a722/secrets.json")
            // .AddJsonFile("appsettings.json")
            // .AddJsonFile($"appsettings.{environment}.json", optional: true)
            .AddEnvironmentVariables();
        var configurationRoot = builder.Build();

        //C:\Repos\Konsolenanwendungen\SOLID\WetterAppDL\WetterApp\bin\Debug\net7.0\appsettings.json


        return configurationRoot.GetSection(sectionName).Get<T>();
    }
}