using System;
namespace CSTheory
{
	public class Week3CharacterRepresentation
	{
		public Week3CharacterRepresentation()
        {
            // Write a program to convert between ASCII/Unicode values and the
            // symbol represented (e.g. ord(), chr() functions in Python)

            Console.WriteLine((char)65);
            Console.WriteLine((char)97);
            Console.WriteLine((int)'A');
            Console.WriteLine((int)'a');
            Console.ReadLine();

            // Find out how to print unicode characters

            Console.WriteLine('\u2614');
            Console.WriteLine('\u260E');
            Console.WriteLine('\u262F');
            Console.ReadLine();

            // Write a program to use bit masks to convert between upper and lower case

            Console.WriteLine(LowerToUpper('a'));
            Console.WriteLine(LowerToUpper('e'));
            Console.WriteLine(LowerToUpper('g'));
            Console.WriteLine(LowerToUpper('z'));
            Console.ReadLine();


            Console.WriteLine(UpperToLower('A'));
            Console.WriteLine(UpperToLower('E'));
            Console.WriteLine(UpperToLower('G'));
            Console.WriteLine(UpperToLower('Z'));
            Console.ReadLine();

            // Write a program to convert a char digit to its integer value using a bitmask

            Console.WriteLine(AlphaToInt('a'));
            Console.WriteLine(AlphaToInt('A'));
            Console.WriteLine(AlphaToInt('e'));
            Console.WriteLine(AlphaToInt('E'));
            Console.WriteLine(AlphaToInt('g'));
            Console.WriteLine(AlphaToInt('G'));
            Console.WriteLine(AlphaToInt('z'));
            Console.WriteLine(AlphaToInt('Z'));

            Console.ReadLine();
        }

        public static char LowerToUpper(char lower)
        {
            return (char)(lower & 95); // 95 = 1011111
        }

        public static char UpperToLower(char upper)
        {
            return (char)(upper | 96); // 96 = 1100000
        }

        public static int AlphaToInt(char alpha)
        {
            return alpha & 31; // 31 = 0011111
        }
	}
}