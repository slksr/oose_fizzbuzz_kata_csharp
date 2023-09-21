using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.FizzBuzzKata.FizzBuzzLogic
{
    public class KataPlayerNameGenerator
    {
        private readonly NameGenerator nameGenerator;
        private readonly List<Player> players = new List<Player>();

        public KataPlayerNameGenerator(NameGenerator nameGenerator)
        {
            this.nameGenerator = nameGenerator;
        }
        public List<Player> Players => players;

        public void AddRandomPlayer()
        {
            players.Add(new Player(nameGenerator.GenerateRandomName()));
        }
    }
}
