using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.Tests
{
    public class FizzBuzzFixture
    {
        public FizzBuzzFixture()
        {
            Mock<NameGenerator> mock = new Mock<NameGenerator>();
            mock.Setup(x => x.GenerateRandomName()).Returns("testname");

            FizzBuzz = new FizzBuzz(mock.Object);
        }


        public FizzBuzz FizzBuzz { get; private set; }
    }
}
