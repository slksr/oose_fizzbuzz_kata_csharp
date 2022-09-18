using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.FizzBuzzKata.FizzBuzzLogic
{
    public class NameGenerator
    {
        private Random random = new Random();
        private string[] names;

        public NameGenerator()
        {
            SetNames();
        }

        public virtual string GenerateRandomName()
        {
            return names[random.Next(names.Length)];
        }

        private void SetNames()
        {
            names = new string[] { "Donald", "Daffy", "Minnie", "Dagobert", "Kwik", "Kwek", "Kwak", "Guus"};
        }


    }
}
