namespace OOSE.FizzBuzzKata.FizzBuzzLogic
{
    public class FizzBuzz
    {
        private readonly NameGenerator nameGenerator;
        private readonly List<Player> players = new List<Player>();

        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public List<Player> Players => players;

        public FizzBuzz(NameGenerator nameGenerator)
        {
            this.nameGenerator = nameGenerator;
        }

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

        public void AddRandomPlayer()
        {
            players.Add(new Player(nameGenerator.GenerateRandomName()));
        }
    }
}