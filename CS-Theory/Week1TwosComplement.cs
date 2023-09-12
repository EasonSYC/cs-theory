using System;
namespace CSTheory
{
	public class Week1TwosComplement
	{
		public static void Fun()
		{
            // Write a program to take a number in two's complement that will return the negative inverse of it.
            // Assume 8 bits (unless you want to generalise... but it would be nice to be able to specify the number of bits being used)


            // Test with 10001000 --> 01111000
            Console.WriteLine(Task("10001000"));


            // Test with 0100 --> 1010 (1100?)
            Console.WriteLine(Task("0100"));

            Console.ReadLine();
        }

		private static string Task(string str)
		{
			string inverseStr = "";

			for(int i = 0; i < str.Length; ++i)
			{
				if (str[i] == '0')
				{
					inverseStr = inverseStr + "1";
				}
				else if (str[i] == '1')
				{
                    inverseStr = inverseStr + "0";
				}
			}

			str = inverseStr;

			string addOne = "";
			bool carryOn = false;

			if (str[str.Length - 1] == '1')
			{
				addOne = '0' + addOne;
				carryOn = true;
			}
			else if (str[str.Length - 1] == '0')
			{
				addOne = '1' + addOne;
				carryOn = false;
			}

			for(int i = str.Length - 2; i >= 0; --i)
			{
				if (str[i] == '0' && carryOn == false)
				{
					addOne = '0' + addOne;
				}
				else if (str[i] == '0' && carryOn == true)
				{
					addOne = '1' + addOne;
					carryOn = false;
				}
				else if (str[i] == '1' && carryOn == false)
				{
					addOne = '1' + addOne;
					carryOn = false;
				}
				else if (str[i] == '1' && carryOn == true)
				{
					addOne = '0' + addOne;
					carryOn = true;
				}
			}

			str = addOne;

			return str;
		}
    }
}

