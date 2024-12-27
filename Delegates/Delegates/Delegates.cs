using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegates
    {
        public delegate void PrintMessage (string message);
        public static void PrintToConsole(string message)
        {
            Console.WriteLine("Console: " + message);
        }

        public static void PrintToFile(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}
