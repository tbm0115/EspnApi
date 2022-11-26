using System;

namespace EspnApi.Models
{
    public class FootballCalendarEntry
    {
        public string Label { get; set; }

        public string AlternateLabel { get; set; }

        public string Detail { get; set; }

        public string Value { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
