using System.Collections.Generic;

namespace EspnApi.Models.Contracts
{
    public abstract class EventSummary : IEventSummary
    {
        public Boxscore Boxscore { get; set; }

        public Dictionary<string, EventFormat> Format { get; set; }

        public Header Header { get; set; }
    }
}
