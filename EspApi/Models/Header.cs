namespace EspnApi.Models
{
    public class Header
    {
        public string Id { get; set; }

        public string Uid { get; set; }

        public SeasonType Season { get; set; }

        public bool TimeValid { get; set; }

        public Competition[] Competitions { get; set; }

    }
}
