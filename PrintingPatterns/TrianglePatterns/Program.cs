using System;

namespace TrianglePatterns
{
	class Program
	{


		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Priniting pattern (A)");
            Console.WriteLine(" ");
            int i = 1;

            while (i <= 10)
                {
               for(int k =1; k<= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                i++;
                }
            Console.WriteLine("--------------------------------------------------------------------------");
		}

		static void DisplayPatternB()
		{
            Console.WriteLine("Priniting pattern (B)");
            Console.WriteLine(" ");

            int i = 10;

            while (i >= 1)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                i--;
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }

        static void DisplayPatternC()
		{
            Console.WriteLine("Priniting pattern (C)");
            Console.WriteLine(" ");

            int i = 1;
            while (i <= 10)
            {
               for (int k=1; k<i; k++)
                {
                    Console.Write(" ");
                }
                for (int j=0; j<=10-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                i++;
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }



        static void DisplayPatternD()
		{
            Console.WriteLine("Priniting pattern (D)");
            Console.WriteLine(" ");

            int i = 1;

            while (i <= 10)
            {
                for (int k = 1; k <=10-i; k++)
                {
                    Console.Write(" ");
                }
                for(int j =1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                i++;
            }
            Console.WriteLine("------------------------------------------------------------------------------- ");
        }
	}
}
