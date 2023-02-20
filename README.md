# WetterAppDL als Konsolenanwendung
dotnet run

Nach SOLID Prinzipien programmiert mit dem Fokus auf verständlichen und wartbaren Code!

Ideengeber: Thorsten Diekhof

Wetterdaten von: https://openweathermap.org/weather-data

Die WebApi ist als App-Geheimnis gespeichert und muss von Euch vorab hinterlegt werden:

Hier eine kleine Anleitung:
https://learn.microsoft.com/de-de/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=windows


In diesem Pfad werden die Geheimnisse gespeichert in: %APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json

1. Aktivieren des Geheimnissppeichers über CLI (Command Line Interface von Visual Studio Code)

dotnet user-secrets init

    Erstellt in der Projektdatei *csproj eine Zusätzliche Zeile:
    <user_secrets_id> = <UserSecretsId>bb047b8533a73416074904922e3c1cfb</UserSecretsId>

2. Festlegen des Geheimnisses:
dotnet user-secrets set "MySecretValues:APP_ID" "bb047b8533a73416074904922e3c1cfb" --project 

    "C:\Repos\Konsolenanwendungen\SOLID\WetterAppDL\WetterApp"
    Successfully saved MySecretValues:APP_ID = bb047b8533a73416074904922e3c1cfb to the secret store.
	
	"C:\Users\diete\AppData\Roaming\Microsoft\UserSecrets\d87b0f3c-4538-4621-afd9-7c5dd0b3a722\secrets.json"	
	Inhalt:
	{
		"APP_ID:OpenWeatherApiKey": "Bitte besorgt euch ein eigene ID"
	}
	
3. https://www.programmingwithwolfgang.com/use-net-secrets-in-console-application/
Damit in einer Konsolenanwendung auf geheime Daten zugegriffen werden kann, sollte vorab zwei Pakete installiert werden:
Install-Package Microsoft.Extensions.Configuration
Install-Package Microsoft.Extensions.Hosting	


4. Neue Klasse erstellen "SecretAppsettingReader"

	using Microsoft.Extensions.Configuration;

	namespace ReadSecretsConsole;

	public class SecretAppsettingReader
	{
		public T ReadSection<T>(string sectionName)
		{
			var builder = new ConfigurationBuilder()
				.AddJsonFile("C:/Users/diete/AppData/Roaming/Microsoft/UserSecrets/d87b0f3c-4538-4621-afd9-7c5dd0b3a722/secrets.json")
				.AddEnvironmentVariables();
			var configurationRoot = builder.Build();
			return configurationRoot.GetSection(sectionName).Get<T>();
		}
	}	
	
5. In der Main Methode
   using Microsoft.Extensions.Configuration; 

   internal class Program
    {
        static void Main(string[] args)
        {
            var secretAppsettingReader = new SecretAppsettingReader();
            var geheim = secretAppsettingReader.ReadSection<SecretValues>("MySecretValues");
            
            Console.WriteLine($"The user name is: {geheim.APP_ID}");

    usw...