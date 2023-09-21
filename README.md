# oose_fizzbuzz_kata_csharp


## The FizzBuzz Problem
- Write a program that prints the numbers from 1 to 100. 
- But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
- For numbers which are multiples of both three and five print “FizzBuzz”.

## The NameGenerator Problem

In unit tests we need to make sure that we only call code that is inside our testscope. 

Consider the following example:

    public class PlayerNameGenerator
    {
        private NameGenerator nameGenerator = new NameGenerator();
        private List<Player> players = new List<Player>();

        public void AddRandomPlayer()
        {
            players.Add(new Player(nameGenerator.GenerateRandomName()));
        }
    }

### Test-goal: 
- Verify that the method addRandomPlayer creates a player object with the string returned by nameGenerator and adds it to the players list. 
- The collaborator NameGenerator is out-of-scope and **must not** be called in the test.
