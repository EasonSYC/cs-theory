using System;
namespace CSTheory
{
	public class Week2ComputingUnitsExercise
	{
		public static void Fun()
		{
            // Complete the programming exercise attached in whatever language you wish to use.
            // Ignore the reference to a Jupyter Notebook - just creation your own solution file.

            Console.WriteLine(Task1("3KB"));
            Console.WriteLine(Task1("7MB"));
            Console.ReadLine();

            Console.WriteLine(Task2("3KiB"));
            Console.WriteLine(Task2("7MiB"));
            Console.ReadLine();

            Console.WriteLine(Task3("512MiB", "GiB"));
            Console.WriteLine(Task3("500MB", "GB"));
            Console.WriteLine(Task3("1024KB", "KiB"));
            Console.ReadLine();

            Console.ReadLine();
        }

		public static int Task1(string str)
        {
			if (str.Substring(str.Length - 2) == "KB" || str.Substring(str.Length - 2) == "MB" || str.Substring(str.Length - 2) == "GB" || str.Substring(str.Length - 2) == "TB")
			{
				int num = int.Parse(str.Substring(0, str.Length - 2));

				if (str.Substring(str.Length - 2) == "KB")
				{
					return (int)Math.Pow(10, 3) * num;
				}

                if (str.Substring(str.Length - 2) == "MB")
                {
                    return (int)Math.Pow(10, 6) * num;
                }

                if (str.Substring(str.Length - 2) == "GB")
                {
                    return (int)Math.Pow(10, 9) * num;
                }

                if (str.Substring(str.Length - 2) == "TB")
                {
                    return (int)Math.Pow(10, 12) * num;
                }
            }


			return -1; // I would like to keep the type to int and return -1 for invalid data.
        }

        public static int Task2(string str)
        {
            if (str.Substring(str.Length - 2) == "KB" || str.Substring(str.Length - 2) == "MB" || str.Substring(str.Length - 2) == "GB" || str.Substring(str.Length - 2) == "TB")
            {
                int num = int.Parse(str.Substring(0, str.Length - 2));

                if (str.Substring(str.Length - 2) == "KB")
                {
                    return (int)Math.Pow(10, 3) * num;
                }

                if (str.Substring(str.Length - 2) == "MB")
                {
                    return (int)Math.Pow(10, 6) * num;
                }

                if (str.Substring(str.Length - 2) == "GB")
                {
                    return (int)Math.Pow(10, 9) * num;
                }

                if (str.Substring(str.Length - 2) == "TB")
                {
                    return (int)Math.Pow(10, 12) * num;
                }
            }

            if (str.Substring(str.Length - 3) == "KiB" || str.Substring(str.Length - 3) == "MiB" || str.Substring(str.Length - 3) == "GiB" || str.Substring(str.Length - 3) == "TiB")
            {
                int num = int.Parse(str.Substring(0, str.Length - 3));

                if (str.Substring(str.Length - 3) == "KiB")
                {
                    return (int)Math.Pow(2, 10) * num;
                }

                if (str.Substring(str.Length - 3) == "MiB")
                {
                    return (int)Math.Pow(2, 20) * num;
                }

                if (str.Substring(str.Length - 3) == "GiB")
                {
                    return (int)Math.Pow(2, 30) * num;
                }

                if (str.Substring(str.Length - 3) == "TiB")
                {
                    return (int)Math.Pow(2, 40) * num;
                }
            }

            return -1; // I would like to keep the type to int and return -1 for invalid data.
        }

        public static double Task3(string value, string unit)
        {
            switch (unit)
            {
                case "KB":
                    return Task2(value) / Math.Pow(10, 3);

                case "MB":
                    return Task2(value) / Math.Pow(10, 6);

                case "GB":
                    return Task2(value) / Math.Pow(10, 9);

                case "TB":
                    return Task2(value) / Math.Pow(10, 12);

                case "KiB":
                    return Task2(value) / Math.Pow(2, 10);

                case "MiB":
                    return Task2(value) / Math.Pow(2, 20);

                case "GiB":
                    return Task2(value) / Math.Pow(2, 30);

                case "TiB":
                    return Task2(value) / Math.Pow(2, 40);

                default:
                    return -1;
            }
        }
    }
}

