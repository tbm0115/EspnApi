﻿namespace EspnApi.Models
{
    //https://www.espn.com/apis/devcenter/docs/teams.html
    public class Team
    {
        public string Id { get; set; }

        public string UID { get; set; }

        public string Location { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string DisplayName { get; set; }

        public string ShortDisplayName { get; set; }

        public string Color { get; set; }

        public string AlternateColor { get; set; }

        public bool IsActive { get; set; }

        public TeamVenue Venue { get; set; }

        // TODO: links

        //public string Logo { get; set; }
    }
}
