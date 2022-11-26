using EspnApi.Models.Contracts;

namespace EspnApi.Models
{
    [ApiUrl("http://site.api.espn.com/apis/site/v2/sports/football/nfl/scoreboard")]
    public class NflScoreboard : Scoreboard<FootballLeague> { }
}
