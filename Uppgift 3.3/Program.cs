using System;
namespace Övning_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många hela timmar vill du hyra bilen?");
            string svar = Console.ReadLine();
            int timmar = int.Parse(svar);
            int sum = 80 * timmar;

            switch (timmar)
            {
                case 1:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Det blir " + sum);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Det kostar bara 950 kr");
                        break;
                    }
                    Console.ReadKey();
            }
        }
    }
}