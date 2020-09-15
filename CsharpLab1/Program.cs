using System;

namespace CsharpLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fredrikInput = "29535123p48723487597645723645";
            long totalSumOfNumbers = 0;

            for (int i = 0; i < fredrikInput.Length; i++)
            {
                int stringIndexLength = 0;

                if (!char.IsDigit(fredrikInput[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < fredrikInput.Length; j++)
                {
                    stringIndexLength++;
                    if (!char.IsDigit(fredrikInput[j]))
                    {
                        break;
                    }

                    else if (fredrikInput[i] == fredrikInput[j])
                    {
                        Console.Write(fredrikInput.Substring(0, i));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(fredrikInput.Substring(i, stringIndexLength + 1));
                        Console.ResetColor();

                        Console.Write(fredrikInput.Substring(j + 1));

                        Console.WriteLine();

                        totalSumOfNumbers += long.Parse(fredrikInput.Substring(i, stringIndexLength + 1));

                        break;
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"Total = {totalSumOfNumbers}");
            Console.ReadKey();
        }
    }
}
