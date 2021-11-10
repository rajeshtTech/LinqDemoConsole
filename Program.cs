using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static LinqPracticeConsole.Shared;
using static LinqPracticeConsole.StudentBO;
using static LinqPracticeConsole.EmployeeBO;
using static LinqPracticeConsole.ProductBO;
using static LinqPracticeConsole.StaticDataRepository;

namespace LinqPracticeConsole
{

    public class Program
    {       
        static void Main(string[] args)
        {
            DisplayAndSelect();
        }

        public static void DisplayAndSelect()
        { 
            DisplayAllFunctions();
            SelectFunction(EntityFunctionSelection);            
        }

        private static void DisplayAllFunctions()
        {
            WriteLine("Press Number to Select Function");
            WriteLine("1. Students Functions");
            WriteLine("2. Employees and Department Functions");
            WriteLine("3. Product related Functions");

            WriteLine("   Press Escape Key to End");
        }

        private static void EntityFunctionSelection(char functKey)
        {
            switch (functKey)
            {
                case '1':
                    StudentFunction();
                    break;
                case '2':
                    EmployeeFunction();
                    break;
                case '3':
                    ProductFunction();
                    break;
            }
        }
    }
}
