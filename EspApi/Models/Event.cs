using System;

namespace EspnApi.Models
{
    public class Event
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public EventSeason Season { get; set; }

        public Week Week { get; set; }

    }
}
