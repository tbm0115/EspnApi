namespace EspnApi.Models
{
    public class EventSummaryCompetitor
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public int Order { get; set; }

        public string HomeAway { get; set; }

        public Team Team { get; set; }

        public CompetitorRecord[] Record { get; set; }

        public bool Possession { get; set; }
    }
}
