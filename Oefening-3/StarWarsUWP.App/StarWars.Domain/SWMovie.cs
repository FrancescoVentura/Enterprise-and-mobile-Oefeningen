using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace StarWarsUniverse.Model
{
    public class SWMovie
    {

        public string Title { get; set; }
        public int Episode_ID { get; set; }

        [JsonProperty(PropertyName = "opening_crawl")]
        public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "planets")]
        public List<string> PlanetUris { get; set; }

        public virtual List<SWPlanet> Planets { get; set; }

        private int rating;

        public int Rating
        {
            get { return rating; }
            set
            {
                if (rating != value)
                {
                    rating = value;
                }
            }
        }
    }
}
