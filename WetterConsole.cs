using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterAppDL
{
    internal class WetterConsole
    {
        private OpenWeatherMapClient client;

        public WetterConsole(OpenWeatherMapClient client)
        {
            this.client = client;
        }

        internal void start()
        {
            string Stadt = string.Empty;
            Console.WriteLine("Enter one or more lines of text (press STRG + Z to exit):");
            Console.WriteLine();
            do
            {
                Console.Write("Von welcher Stadt soll das Wetter angezeigt werden? ");
                Stadt = Console.ReadLine();
                if (!string.IsNullOrEmpty(Stadt))
                {
                    //Console.WriteLine("      " + Stadt);
                    zeigWetter(Stadt, GetClient());
                }
            } while (Stadt != null);

        }

        private OpenWeatherMapClient GetClient()
        {
            return client;
        }

        private void zeigWetter(string stadt, OpenWeatherMapClient client)
        {
            var test = client.GetWetterResponseAsync(stadt, new HttpClient());
            //Console.WriteLine(test.Result);
            Console.ReadLine();
        }
    }
}
