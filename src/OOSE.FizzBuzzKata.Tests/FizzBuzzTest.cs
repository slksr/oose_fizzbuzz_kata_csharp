
namespace OOSE.FizzBuzzKata.Tests
{
    public class FizzBuzzTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture fixture;

        public FizzBuzzTest(TestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void ReturnsFizzIfNumberisMulitpleOfThree()
        {
            Assert.Equal("Fizz", fixture.KataFizzBuzz.Turn(3));
            Assert.Equal("Fizz", fixture.KataFizzBuzz.Turn(6));
            Assert.Equal("Fizz", fixture.KataFizzBuzz.Turn(9));
        }

        [Fact]
        public void ReturnsBuzzIfNumberisMulitpleOfFive()
        {
            Assert.Equal("Buzz", fixture.KataFizzBuzz.Turn(5));
            Assert.Equal("Buzz", fixture.KataFizzBuzz.Turn(10));
            Assert.Equal("Buzz", fixture.KataFizzBuzz.Turn(20));
        }

        [Fact]
        public void ReturnsKataFizzBuzzIfNumberisMulitpleOfFifteen()
        {
            Assert.Equal("FizzBuzz", fixture.KataFizzBuzz.Turn(15));
            Assert.Equal("FizzBuzz", fixture.KataFizzBuzz.Turn(45));
        }

        [Fact]
        public void ReturnsEmptyStringIfNumberisMulitpleOfThreeFiveFifteen()
        {
            Assert.Equal("", fixture.KataFizzBuzz.Turn(1));
            Assert.Equal("", fixture.KataFizzBuzz.Turn(2));
            Assert.Equal("", fixture.KataFizzBuzz.Turn(22));
        }

    }
}