namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to carpet cleaner ");


            Console.WriteLine("How many small carpet do you want to wash? ");
            int number1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many large carpet do you want to wash?");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The price for washing a small carpet is 25$");
            Console.WriteLine("The price for washing a large carpet is 35$");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Calculate the price of small carpets is :" + number1 * 25 + "$");
            Console.WriteLine("Calculate the price of large carpets is :" + number2 * 35 + "$");
            Console.WriteLine("------------------------------------------");
            int number3 = number1 * 25 + number2 * 35;
            Console.WriteLine("cost:" + number3 + "$");
            Console.WriteLine("Tax: 6.6$");
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Totel:" + (number3 + (6.6)) + "$");
        }
    }
}
