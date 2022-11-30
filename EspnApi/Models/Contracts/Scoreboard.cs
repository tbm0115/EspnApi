namespace EspnApi.Models.Contracts
{
    //https://www.espn.com/apis/devcenter/docs/scores.html
    public abstract class Scoreboard<TLeague> : IScoreboard where TLeague : ILeague, new()
    {
        public TLeague[] Leagues { get; set; }

        public ScoreboardSeason Season { get; set; }

        public Event[] Events { get; set; }
    }
}
