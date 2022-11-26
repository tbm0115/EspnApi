using EspnApi.Models.Contracts;

namespace EspnApi.Models
{
    [ApiUrl("http://site.api.espn.com/apis/site/v2/sports/baseball/mlb/scoreboard")]
    public class MlbScoreboard : Scoreboard<BaseballLeague> { }
}
