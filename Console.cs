using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleCommands
{
    class ConsoleExecCommands
    {
        public static void Exec(string input, string sl, string tl)
        {
            if (string.IsNullOrEmpty(input))
                return;
            
            Translate(input, sl, tl);
        }

        public static void Translate(string input, string sourcelang = "pt", string targetlang = "en")
        {
            try
            {
                Regex remove = new Regex("[^a-zA-Z0-9 -]"); // Remover símbolos
                input = remove.Replace(input, "");

                string APIurl = String.Format("https://translate.google.com/m?sl={1}&tl={2}&hl=en&q={0}", input, sourcelang, targetlang);
                string WebResult;

                using (WebClient webClient = new WebClient())
                {
                    WebResult = webClient.DownloadString(APIurl);
                }

                string Result = WebResult.Split(new[] { "<div class=\"result-container\">" }, StringSplitOptions.None)[1];
                Result = Result.Split("<")[0].Replace("&#39;", "'");

                Console.WriteLine("[RECEIVED] <= {0}\n", Result) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] => Reason: {0}\n", e);
            }
        }

    }
}
