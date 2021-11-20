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
            new Player() {name = "Chrissy", score = 8},
            new Player() {name = "Doris", score = 7}
        };
        
        var sut = new LeaderBoard(players);
        var playersByRank = sut.GetRank();
        
        Assert.Equal(1, playersByRank.FirstOrDefault().Position);
        Assert.Equal(3, playersByRank.Count);
        

    }
}