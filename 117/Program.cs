using System;

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Groszowe wynagrodzenie.");
            while (true)
            {

                try
                {


                    Console.WriteLine("Wprowadź ilość monet 1 grszowych:");
                    int userInput1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wprowadź ilość monet 2 grszowych:");
                    int userInput2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wprowadź ilość monet 5 grszowych:");
                    int userInput3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wprowadź ilość monet 10 grszowych:");
                    int userInput4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wprowadź ilość monet 50 grszowych:");
                    int userInput5 = int.Parse(Console.ReadLine());

                    decimal result1 = userInput1 * 0.01m;
                    decimal result2 = userInput2 * 0.02m;
                    decimal result3 = userInput3 * 0.05m;
                    decimal result4 = userInput4 * 0.10m;
                    decimal result5 = userInput5 * 0.50m;

                    decimal result = result1 + result2 + result3 + result4 + result5;
                    if (result > 1m)
                    {
                        Console.WriteLine($"Suma jest większa od złotówki. Sumę, którą wprwoadziłeś to {result.ToString("c")}");
                    }
                    else if (result < 1m)
                    {
                        Console.WriteLine($"Suma jest mniejsza od złotówki. Sumę, którą wprwoadziłeś to {result.ToString("c")}");
                    }
                    Console.WriteLine("Jeśli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk. ");
                    string end = Console.ReadLine();
                    if (end.Equals("tak", StringComparison.CurrentCultureIgnoreCase))
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Zły format.");
                }
            }

        }
    }
}
