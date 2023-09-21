using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, FizzBuzz World!");
            KataFizzBuzz fizzBuzz = new KataFizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                var result = fizzBuzz.Turn(i);
                Console.WriteLine($"Result =  {(string.IsNullOrEmpty(result) ? i.ToString() : result) }  ");
            }
        }
    }
}