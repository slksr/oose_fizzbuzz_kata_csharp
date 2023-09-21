using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.Tests
{
    public class TestFixture
    {
        public TestFixture()
        {
            Mock<NameGenerator> mock = new Mock<NameGenerator>();
            mock.Setup(x => x.GenerateRandomName()).Returns("testname");

            KataFizzBuzz = new KataFizzBuzz();
            KataPlayer = new KataPlayerNameGenerator(mock.Object);
        }


        public KataFizzBuzz KataFizzBuzz { get; private set; }
        public KataPlayerNameGenerator KataPlayer { get; }
    }
}
