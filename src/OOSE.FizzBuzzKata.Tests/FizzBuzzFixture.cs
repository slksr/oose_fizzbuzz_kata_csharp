using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.Tests
{
    public class FizzBuzzFixture
    {
        public FizzBuzzFixture()
        {
            FizzBuzz = new FizzBuzz();
        }


        public FizzBuzz FizzBuzz { get; private set; }
    }
}
