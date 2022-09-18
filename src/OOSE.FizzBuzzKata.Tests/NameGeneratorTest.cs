using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.Tests
{
    public class NameGeneratorTest
    {
        [Fact]
        public void GenerateRandomNameTest()
        {
            NameGenerator generator = new NameGenerator();
            var actValue = generator.GenerateRandomName();
            Assert.NotEmpty(actValue);
        }
    }
}
