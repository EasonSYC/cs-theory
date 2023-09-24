using System;
namespace CSTheory
{
	public class Week1NumberBases
	{
		public Week1NumberBases()
		{
            // Research (Bond p28) the successive division algorithm to convert a denary number into a binary number. Implement and test.

            Console.WriteLine(Task1(20));
            Console.ReadLine();

            // Can you write a recursive version of the algorithm?

            Console.WriteLine(Task2(20));
            Console.ReadLine();

            // Expand the program to give the option of converting from denary to octal (base 8).

            Console.WriteLine(Task3(20));
            Console.ReadLine();
        }

        private static string Task1(int number)
        {
            string str = "";

            while(number != 0)
            {
                str = (number % 2).ToString() + str;
                number /= 2;
            }

            return str;
        }

        private static string Task2(int number)
        {
            if(number == 0)
            {
                return "";
            }

            return Task2(number / 2) + (number % 2).ToString();
        }

        private static string Task3(int number)
        {
            if (number == 0)
            {
                return "";
            }

            return Task3(number / 8) + (number % 8).ToString();
        }
    }
}

