using EspnApi.Models.Contracts;

namespace EspnApi.Models
{
    [ApiUrl("http://site.api.espn.com/apis/site/v2/sports/football/college-football/scoreboard")]
    public class CollegeFootballScoreboard : Scoreboard<FootballLeague> { }
}
