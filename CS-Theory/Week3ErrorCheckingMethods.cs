using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;



namespace CSTheory
{
    public class Week3ErrorCheckingMethods
    {
        public Week3ErrorCheckingMethods()
        {
            // Write a program to read a byte of data as a string e.g. "00110010"
            // that uses the XOR operator on each of the first 7 bits to determine
            // the expected parity(assume odd parity) bit value.
            // The program should state whether the input was valid or invalid.

            Console.WriteLine(ParityTest("00110010")); // Valid
            Console.WriteLine(ParityTest("00111010")); // Invalid
            Console.WriteLine(ParityTest("00101010")); // Valid

            Console.ReadLine();

            // Write a program to perform an ISBN calculation / check.

            Console.WriteLine(ISBNTest("1119974526")); // Valid
            Console.WriteLine(ISBNTest("0306406152")); // Valid
            Console.WriteLine(ISBNTest("0706406152")); // Invalid

            Console.ReadLine();

            // Test ISBN 13-digit

            Console.WriteLine(ISBNTest13("9781471839511"));
            Console.WriteLine(ISBNTest13("9781910523071"));
            Console.WriteLine(ISBNTest13("9781292359991"));

            Console.ReadLine();
        }

        public static bool ParityTest(string str)
        {
            bool valNow = ((str[0] - '0') == 1) ? true : false;

            for (int i = 1; i < 7; ++i)
            {
                valNow ^= ((str[i] - '0') == 1) ? true : false;
            }

            return valNow == (((str[7] - '0') == 1) ? false : true);
        }

        public static bool ISBNTest(string str)
        {
            int testSum = 0;

            for (int i = 0; i < 9; ++i)
            {
                testSum += (str[i] - '0') * (i + 1);
            }

            testSum %= 11;

            if (testSum == str[9] - '0')
            {
                return true;
            }
            return false;
        }

        public static bool ISBNTest13(string str)
        {
            int testSum = 0;

            for (int i = 0; i < 12; ++i)
            {
                testSum += (str[i] - '0') * ((i % 2 == 0) ? 1 : 3);
            }

            testSum %= 10;

            if ((10 - testSum) % 10 == str[12] - '0')
            {
                return true;
            }
            return false;
        }
    }
}

