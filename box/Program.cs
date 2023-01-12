using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j ;

            for(i=0;i<=20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 0; j++)
                {

                    Console.Write("*");
                }
                for (j = 0; j <= 0; j++)
                {
                    Console.Write("                   ");
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }



            Console.Write("    ");


            for (i = 0; i <= 12; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();    

          
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 0; j++)
                {

                    Console.Write("*");
                }
                for (j = 0; j <= 0; j++)
                {
                    Console.Write("   ");
                    Console.Write("*");
                }
                for (j = 0; j <= 0; j++)
                {
                    Console.Write("           ");
                    Console.Write("*");
                }
                for (j = 0; j <= 0; j++)
                {
                    Console.Write("   ");
                    Console.Write("*");
                }
                Console.WriteLine(" ");



            }
            Console.Write("    ");


            for (i = 0; i <= 12; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 0; j++)
                {

                    Console.Write("*");
                }
                for (j = 0; j <= 0; j++)
                {
                    Console.Write("                   ");
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
            for (i = 0; i <= 20; i++)
            {
                Console.Write("*");
            }




            Console.ReadKey();   
        }

    }
}
