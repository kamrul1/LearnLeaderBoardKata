using System.Collections.Generic;
using System.Linq;
using LearnLearderBoardKata.Library;
using Xunit;

namespace LearnLeaderBoardKata.Library.Tests;

public class LeaderBoardTests
{

    [Fact]
    public void ShouldReturnPlayerByRankOrder()
    {
        List<Player> players = new List<Player>()
        {
            new Player {name = "Ardalis", score = 10},
            new Player() {name = "Bob", score = 9},
            new Player() {name = "Chrissy", score = 7},
            new Player() {name = "Doris", score = 8}
        };
        
        var sut = new LeaderBoard(players);
        var playersByRank = sut.GetRank();
        
        Assert.Equal(1, playersByRank.FirstOrDefault().Position);
        Assert.Equal("Ardalis", playersByRank.FirstOrDefault().Name);
        Assert.Equal("Chrissy", playersByRank.LastOrDefault().Name);
        Assert.Equal(4, playersByRank.Count);
    }
}