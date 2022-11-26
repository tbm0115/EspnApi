namespace EspnApi.Models.Contracts
{
    public abstract class Scoreboard<TLeague> : IScoreboard where TLeague : ILeague, new()
    {
        public TLeague[] Leagues { get; set; }

        public ScoreboardSeason Season { get; set; }

        public Event[] Events { get; set; }
    }
}
