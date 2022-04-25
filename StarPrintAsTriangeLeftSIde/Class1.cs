using System;
using System.Collections.Generic;
using System.Text;

namespace StarPrintAsTriangeLeftSIde
{
    internal class Class1
    {
        public static void starprint()
        {
            for (int i = 6; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
               Console.WriteLine();
            }
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
