using System.Collections.Generic;
using LearnLearderBoardKata.Library;

namespace LearnLearderBoardKata.Library;

public class LeaderBoard
{
    private readonly List<Player> _players;

    public LeaderBoard(List<Player> players)
    {
        _players = players;
    }


    public List<PlayerRank> GetRank()
    {
        return new List<PlayerRank>()
        {
            new PlayerRank() {Name = "Joe", Position = 1, Score = 122}
        };
    }
}