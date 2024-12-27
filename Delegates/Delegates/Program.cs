// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using static Delegates.Delegates;
namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            //  PrintMessage printMessageDel = new PrintMessage(PrintToConsole);
            // printMessageDel("Delegates");


            // for multicast delegate
            PrintMessage printMessageDel = PrintToConsole;
            printMessageDel += PrintToFile;
            printMessageDel("Mulicast Delegate");
        }
    }
}