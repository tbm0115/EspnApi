using System;

namespace EspnApi.Models
{
    public class Logo
    {
        public string Href { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Alt { get; set; }

        public string[] Rel { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
