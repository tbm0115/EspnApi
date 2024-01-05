using EspnApi.Models.Contracts;
using Newtonsoft.Json;

namespace EspnApi.Models.Responses
{
    public class TeamsResponse : IResponse
    {
        [JsonProperty("sports")]
        public Sport[] Sports { get; set; }

        public class Sport
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("uid")]
            public string UID { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("slug")]
            public string Slug { get; set; }

            [JsonProperty("leagues")]
            public League[] Leagues { get; set; }

            public class League
            {
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("uid")]
                public string UID { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("abbreviation")]
                public string Abbreviation { get; set; }

                [JsonProperty("shortName")]
                public string ShortName { get; set; }

                [JsonProperty("slug")]
                public string Slug { get; set; }

                [JsonProperty("teams")]
                public Team[] Teams { get; set; }

                public class LeagueTeam
                {
                    [JsonProperty("team")]
                    public Team Team { get; set; }
                }
            }
        }
    }
}
