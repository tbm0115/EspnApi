using System;

namespace EspnApi.Models
{
    public class HeaderCompetition
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public DateTime Date { get; set; }

        public bool NeutralSite { get; set; }

        public bool ConferenceCompetition { get; set; }

        public bool BoxscoreAvailable { get; set; }

    }
}
