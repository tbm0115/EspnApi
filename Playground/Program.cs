using ConsoulLibrary;
using EspnApi;
using EspnApi.Models;
using Newtonsoft.Json;

namespace SportsSign.Config
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Consoul.Write("Connecting to ESPN NFL Scoreboard...");

            using (var wa = new WebAccessor())
            {
                var scoreboard = wa.GetScoreboardAsync<NflScoreboard>().Result;
                Consoul.Write(JsonConvert.SerializeObject(scoreboard), ConsoleColor.Cyan);

                var firstEvent = scoreboard.Events.FirstOrDefault();
                if (firstEvent != null)
                {
                    var eventSummary = wa.GetEventSummaryAsync<NflEventSummary>(firstEvent.Id).Result;

                    Consoul.Write(JsonConvert.SerializeObject(eventSummary), ConsoleColor.DarkCyan);
                }

            }

            Consoul.Wait();
        }
    }
}