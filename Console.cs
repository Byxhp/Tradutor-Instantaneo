using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleCommands
{
    class ConsoleExecCommands
    {
        public static void Exec(string input)
        {
            if (string.IsNullOrEmpty(input))
                return;
            
            Translate(input);
        }

        public static void Translate(string input, string sourcelang = "pt", string targetlang = "en")
        {
            Console.WriteLine("[SEND] => {0}", input);

            try
            {
                string APIurl = String.Format("https://translate.google.com/m?sl={1}&tl={2}&hl=en&q={0}", input, sourcelang, targetlang);
                string WebResult;

                using (WebClient webClient = new WebClient())
                {
                    WebResult = webClient.DownloadString(APIurl);
                }

                string Result = WebResult.Split(new[] { "<div class=\"result-container\">" }, StringSplitOptions.None)[1];
                Result = Result.Split("<")[0];

                Console.WriteLine("[RECEIVED] => {0}", Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] => Reason: {0}", e);
            }
        }
    }
}
