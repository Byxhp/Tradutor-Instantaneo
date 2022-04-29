using ConsoleCommands;
using System;

namespace Tradutor_Instantâneo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.CursorVisible = true;
                ConsoleExecCommands.Exec(Console.ReadLine());
            }
        }
    }
}
