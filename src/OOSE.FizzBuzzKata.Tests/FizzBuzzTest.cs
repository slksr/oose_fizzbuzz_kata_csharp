using Moq;
using OOSE.FizzBuzzKata.FizzBuzzLogic;

namespace OOSE.FizzBuzzKata.Tests
{
    public class FizzBuzzTest : IClassFixture<FizzBuzzFixture>
    {
        private readonly FizzBuzzFixture fixture;

        public FizzBuzzTest(FizzBuzzFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void ReturnsFizzIfNumberisMulitpleOfThree()
        {
            Assert.Equal("Fizz", fixture.FizzBuzz.Turn(3));
            Assert.Equal("Fizz", fixture.FizzBuzz.Turn(6));
            Assert.Equal("Fizz", fixture.FizzBuzz.Turn(9));
        }

        [Fact]
        public void ReturnsBuzzIfNumberisMulitpleOfFive()
        {
            Assert.Equal("Buzz", fixture.FizzBuzz.Turn(5));
            Assert.Equal("Buzz", fixture.FizzBuzz.Turn(10));
            Assert.Equal("Buzz", fixture.FizzBuzz.Turn(20));
        }

        [Fact]
        public void ReturnsFizzBuzzIfNumberisMulitpleOfFifteen()
        {
            Assert.Equal("FizzBuzz", fixture.FizzBuzz.Turn(15));
            Assert.Equal("FizzBuzz", fixture.FizzBuzz.Turn(45));
        }

        [Fact]
        public void ReturnsEmptyStringIfNumberisMulitpleOfThreeFiveFifteen()
        {
            Assert.Equal("", fixture.FizzBuzz.Turn(1));
            Assert.Equal("", fixture.FizzBuzz.Turn(2));
            Assert.Equal("", fixture.FizzBuzz.Turn(22));
        }

        [Fact]
        public void AddsRandomNameToPlayerList()
        {
            // act
            fixture.FizzBuzz.AddRandomPlayer();
            // assert
            Assert.Equal("testname", fixture.FizzBuzz.Players.First().Name);
        }
    }
}