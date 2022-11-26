using System;

namespace EspnApi.Models
{
    public class FootballCalendar
    {
        public string Label { get; set; }

        public string Value { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public FootballCalendarEntry[] Entries { get; set; }
    }
}
