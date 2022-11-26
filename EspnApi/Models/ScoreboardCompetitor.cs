namespace EspnApi.Models
{
    public class ScoreboardCompetitor
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public string Type { get; set; }

        public int Order { get; set; }

        public string HomeAway { get; set; }

        public bool Winner { get; set; }

        public string Score { get; set; }

        public LineScore[] LineScores { get; set; }
    }
}
