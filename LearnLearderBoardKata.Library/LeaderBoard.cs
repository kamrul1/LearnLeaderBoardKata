using System.Collections.Generic;
using System.Linq;
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
        var _sortedPlayers = _players.OrderByDescending(x => x.score);

        var _playerRanks = new List<PlayerRank>();

        foreach (var _player in _sortedPlayers)
        {
            var x = 1;
            _playerRanks.Add(new PlayerRank() {Name = _player.name, Position = x, Score = _player.score});
            x++;
        }

        return _playerRanks;

    }
}