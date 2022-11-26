using EspnApi.Models.Contracts;

namespace EspnApi.Models
{
    [ApiUrl("http://site.api.espn.com/apis/site/v2/sports/baseball/college-baseball/scoreboard")]
    public class CollegeBaseballScoreboard : Scoreboard<BaseballLeague> { }
}
