using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Text.RegularExpressions; 

namespace LinearEquationGrapher 
{ 
    class Graph 
    { 
        private string equation; 
        private int slope; 
        private int yAxisMax = 100; 
        private bool hasNoSlope; 

        public Graph(string equation) 
        { 
            this.equation = equation; 
        } 

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        ///                          <summary> . </summary> 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public bool IsValidEquation() 
        { 
            bool hasValidEquation = true; 

            Regex regExSlopebiggerThanX = new Regex(@"^[y][=][0-9]{1,3}[x]{1}$"); 
            Regex regExSlopeSameAsX = new Regex(@"^[y][=][x]{1}$"); 
            Regex regExNoSlope = new Regex(@"^[y][=][0-9]{1,3}$"); 

            bool hasValidEquatSlope = regExSlopebiggerThanX.IsMatch(equation); 
            bool hasValidEquatSameSlopeAsX = regExSlopeSameAsX.IsMatch(equation); 
            bool hasValidEquatNoSlope = regExNoSlope.IsMatch(equation); 

            if (hasValidEquatSlope)  slope = Convert.ToInt32(equation.Substring(2, 1)); 
            else if (hasValidEquatSameSlopeAsX)  slope = 1; 
            else if (hasValidEquatNoSlope) 
            { 
                slope = 0; 
                hasNoSlope = true; 
            } 

            else  hasValidEquation = false; 

            PrintValidationTest(hasValidEquation); 
            return hasValidEquation; 
        } 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        ///                          <summary> . </summary> 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void PrintValidationTest(bool hasValidEquation) 
        { 
            if (hasValidEquation) 
            { 
                Console.WriteLine("\t\t============================="); 
                Console.WriteLine("\t\t\t- Equation is valid"); 
                Console.WriteLine("\t\t\t- Slope = {0}", slope); 
                Console.WriteLine("============================="); 
            } 

            else 
            { 
                Console.WriteLine(""); 
                Console.WriteLine("**** Equation is Invalid!!***"); 
                Utility.PrintHelpOptions(); 
            } 
        } 

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        ///                          <summary> . </summary> 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 

        public void PlotPointsOnLine() 
        { 
            int x = yAxisMax; 
            int y; 

            for (int yRow = 0; yRow < yAxisMax && x > 0; yRow++)       // y = mx | x = y/m 
            { 
                if (hasNoSlope) 
                { 
                    y = (yAxisMax - yRow); 
                    x = y;  // y=x 
                } 
                else x = y / slope;     // LINE IS CONSTANT, SLOPE IS O 

                PrintSpaces(x); 

                Console.Write("*"); 
                Console.WriteLine("          x,y = ({0},{1})  {1} = {2}*{0}", x, y, slope); 
            } 
            Console.WriteLine(""); 

        } 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        ///                          <summary> . </summary> 
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        public void PrintSpaces(int x) 
        { 
            for (int i = 0; i < x; i++) 
                Console.Write(" "); 
        } 
    } 
} 
