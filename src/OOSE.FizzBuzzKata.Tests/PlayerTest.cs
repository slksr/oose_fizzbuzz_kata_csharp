using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.FizzBuzzKata.Tests
{
    public class PlayerTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture fixture;

        public PlayerTest(TestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void AddsRandomNameToPlayerList()
        {
            // act
            fixture.KataPlayer.AddRandomPlayer();
            // assert
            Assert.Equal("testname", fixture.KataPlayer.Players.First().Name);
        }
    }
}
