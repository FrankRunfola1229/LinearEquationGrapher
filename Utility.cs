using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace LinearEquationGrapher 
{ 
    static class Utility 
    { 
        public static void PrintProgramHeader() 
        { 
            Console.WriteLine("**********************************************************"); 
            Console.WriteLine(" Welcome to Frank's Graphing Program..."); 
            Console.WriteLine("**********************************************************"); 
            Console.WriteLine("     Input options:"); 
            Console.WriteLine("          1) Enter equation to be graphed (ie y=x|y=2x|y=5)"); 
            Console.WriteLine("          2) Type \"exit\" to quit program"); 
            Console.WriteLine("**********************************************************"); 
            Console.WriteLine(""); 
        } 
        public static void PrintProgramExit() 
        { 
            Console.WriteLine(""); 
            Console.WriteLine("**********************************************************"); 
            Console.WriteLine(" Thanks for using Frank's Graphing Program!"); 
            Console.WriteLine("**********************************************************"); 

        } 
        public static void PrintHelpOptions() 
        { 
            Console.WriteLine(""); 
            Console.WriteLine("   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); 
            Console.WriteLine("   Input options:"); 
            Console.WriteLine("        1) Enter equation to be graphed (ie y=x|y=2x|y=5)"); 
            Console.WriteLine("        2) Type \"exit\" to quit program"); 
            Console.WriteLine("   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); 
            Console.WriteLine(""); 
        } 
    } 
}
