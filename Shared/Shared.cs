using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LinqPracticeConsole
{
   
    public class Shared
    {
        public delegate void CallSelectedBOFunction(char funcKey);
        static char GetSelectedFunctionKey()
        {
            return ReadKey().KeyChar;
        }

        public static void SelectFunction(CallSelectedBOFunction callSelectedBOFunction)
        {
            var funcKey = GetSelectedFunctionKey();
            do
            {
                WriteLine("\n");
                callSelectedBOFunction(funcKey);
                funcKey = GetSelectedFunctionKey();
            }
            while (funcKey != 27); // Char Code 27 = Escape Key
        }
    
    }
}
