using EspnApi.Models.Contracts;

namespace EspnApi.Models
{
    [ApiUrl("http://site.api.espn.com/apis/site/v2/sports/soccer/usa.1/scoreboard")]
    public class MlsScoreboard : Scoreboard<SoccerLeague> { }
}
