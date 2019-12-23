
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Text.RegularExpressions; 
// ============================================================================================== 
// PROGRAM:  LinearLineGrapher                 
// AUTHOR:   Frank Runfola 
// DATE:     2/16/2017 
//---------------------------------------------------------------------------------------------- 
// ABOUT:    * Write a program that does the following 
//           * Takes in a simple linear equation 
//           * Graph the equation 
//---------------------------------------------------------------------------------------------- 
// INPUT:  A linear quation (ie y=x|y=2x|y=5) 
// OUTPUT: Star pattern line graph 
//---------------------------------------------------------------------------------------------- 
//                     Example 
//------------------------------------------------------ 
// Enter Equation: y=x 
//                                                                          * 
//                                                                  * 
//                                                          * 
//                                                  * 
//                                          * 
//                                  * 
//                          * 
//                  * 
//          * 
//* 
/**********************************************************************************************/ 
namespace LinearEquationGrapher 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Utility.PrintProgramHeader(); 
            Console.Write(">"); 
            string inputEquation = Console.ReadLine(); 
            Graph graphObj; 

            while (inputEquation != "exit") 
            {                 
                graphObj = new Graph(inputEquation); 

                if (graphObj.IsValidEquation()) 
                    graphObj.PlotPointsOnLine(); 

                Console.Write(">"); 
                inputEquation = Console.ReadLine(); 
            } 

            Utility.PrintProgramExit(); 
        } 
    } 
} 
