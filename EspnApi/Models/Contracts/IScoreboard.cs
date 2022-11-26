namespace EspnApi.Models.Contracts
{
    public interface IScoreboard
    {
        public ScoreboardSeason Season { get; set; }

        public Event[] Events { get; set; }
    }
}
