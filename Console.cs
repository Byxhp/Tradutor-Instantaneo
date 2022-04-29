using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleCommands
{
    class ConsoleCommands
    {
        public static void Exec(string input)
        {
            
        }

        public static void Translate(string input, string sourcelang = "pt", string targetlang = "en")
        {
            Console.WriteLine("[SEND] => {0}", input);

            try
            {
                string APIurl = String.Format("", input, sourcelang);
                string WebResult;

                using (WebClient webClient = new WebClient())
                {
                    WebResult = webClient.DownloadString(APIurl);
                }
                Console.WriteLine("[RECEIVED] => {0}", WebResult.Trim());
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] => Reason: {0}", e);
            }
        }
    }
}
