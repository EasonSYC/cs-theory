using System;
namespace CSTheory
{
	public class Week1NumberSystems
	{
        public Week1NumberSystems()
        {
            // Research Gauss's method to calculate the sum of the first 50 natural numbers.
            // Write a formula in terms of n to calculate the sum of all the natural numbers from 1 to n.

            Console.WriteLine(Task1(50));
            Console.ReadLine();

            // Write two programs. One to use Gauss's method, and another using a 'brute-force' approach.
            // Compare the execution times to sum the first 10,000 natural numbers. What do you notice?

            Console.WriteLine(Task1(10000));
            Console.WriteLine(Task2(10000));
            Console.ReadLine();

            // Research either the Gregory-Leibniz or the Nilakantha series to produce
            // a program to give an approximation to the irrational number pi (Bond p16).

            Console.WriteLine(Task3GregoryLeibniz(10000));
            Console.WriteLine(Task3Nilakantha(10000));
            Console.ReadLine();
        }

        // Research Gauss's method to calculate the sum of the first 50 natural numbers.
        // Write a formula in terms of n to calculate the sum of all the natural numbers from 1 to n.

        private static int Task1(int n)
		{
			return n * (n + 1) / 2;
		}

        // Write two programs. One to use Gauss's method, and another using a 'brute-force' approach.
        // Compare the execution times to sum the first 10,000 natural numbers. What do you notice?

        private static int Task2(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; ++i)
            {
                sum += i;
            }

            return sum;
        }

        // Research either the Gregory-Leibniz or the Nilakantha series to produce
        // a program to give an approximation to the irrational number pi (Bond p16).

        private static double Task3GregoryLeibniz(int number)
        {
            double pi = 0;

            for(int i = 1; i <= number; ++i)
            {
                pi += Math.Pow(-1, i - 1) * 1 / (2 * i - 1);
            }

            pi *= 4;

            return pi;
        }

        private static double Task3Nilakantha(int number)
        {
            double pi = 0;

            for(int i = 1; i <= number; ++i)
            {
                pi += Math.Pow(-1, i - 1) * 1 / ((2 * i) * (2 * i + 1) * (2 * i + 2));
            }

            pi *= 4;
            pi += 3;

            return pi;
        }
    }
}

