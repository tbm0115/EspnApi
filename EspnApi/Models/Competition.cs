using System;

namespace EspnApi.Models
{
    public class Competition
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public DateTime Date { get; set; }

        public int Attendance { get; set; }

        public CompetitionType Type { get; set; }

        public bool TimeValid { get; set; }

        public bool NeutralSite { get; set; }

        public bool ConferenceCompetition { get; set; }

        public bool Recent { get; set; }

        public EventVenue Venue { get; set; }

        public string BoxscoreSource { get; set; }

        public string PlayByPlaySource { get; set; }

        public ScoreboardCompetitor[] Competitors { get; set; }

        public CompetitionStatus Status { get; set; }
    }
}
