using System.Collections.Generic;

namespace EspnApi.Models.Contracts
{
    public interface IEventSummary
    {
        public Boxscore Boxscore { get; set; }

        public Dictionary<string, EventFormat> Format { get; set; }

        // TODO: gameInfo

        // TODO: lastFiveGames

        // TODO: leaders

        // TODO: injuries

        // TODO: broadcasts

        // TODO: predictor

        // TODO: pickcenter

        // TODO: againstTheSpread

        // TODO: odds

        public Header Header { get; set; }

        // TODO: news

        // TODO: article

        // TODO: videos

        // TODO: ticketsInfo

        // TODO: standings
    }
}
