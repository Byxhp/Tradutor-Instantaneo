using ConsoleCommands;
using System;

namespace TradutorInstantaneo
{
    class Program
    {
        public static string SL = "pt"; // Língua de origem [Source language]
        public static string TL = "en"; // Língua de destino [Target language]

        static void Main(string[] args)
        {
            Console.WriteLine("Olá, configure as línguas abaixo para continuar...\n");

            Console.Write("Digite a sigla da sua língua de ORIGEM [PT, EN, ES, etc...]: ");
            SL = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Língua de [ORIGEM] definida para: [{0}]!\n", SL);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite a sigla da sua língua de DESTINO [PT, EN, ES, etc...]: ");
            TL = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Língua de [DESTINO] para: [{0}]!\n", TL);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite abaixo para traduzir...\n");

            while (true)
            {
                Console.CursorVisible = true;
                ConsoleExecCommands.Exec(Console.ReadLine());
            }
        }
    }
}
