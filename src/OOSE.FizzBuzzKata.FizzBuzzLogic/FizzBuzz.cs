namespace OOSE.FizzBuzzKata.FizzBuzzLogic
{
    public class FizzBuzz
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
 

        public string Turn(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return Fizz + Buzz;
            }
            else if (number % 3 == 0)
            {
                return Fizz; 
            }
            else if (number % 5 == 0)
            {
                return Buzz;
            }
            return "";
        }
    }
}