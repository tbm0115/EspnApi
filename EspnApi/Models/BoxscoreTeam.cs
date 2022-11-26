namespace EspnApi.Models
{
    public class BoxscoreTeam
    {
        public Team Team { get; set; }

        public TeamStatistics[] Statistics { get; set; }
    }
}
