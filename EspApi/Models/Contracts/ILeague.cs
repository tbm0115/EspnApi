using System;

namespace EspnApi.Models.Contracts
{
    public interface ILeague
    {
        public int Id { get; set; }

        public string Uid { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string Slug { get; set; }

        public Season Season { get; set; }

        public Logo[] Logos { get; set; }

        public string CalendarType { get; set; }

        public bool CalendarIsWhiteList { get; set; }

        public DateTime CalendarStartDate { get; set; }

        public DateTime CalendarEndDate { get; set; }
    }
}
