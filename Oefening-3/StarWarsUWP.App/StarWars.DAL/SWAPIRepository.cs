using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsUniverse.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace StarWars.DAL
{
    public class SWAPIRepository : IStarWarsRepository
    {
        public SWMovie GetMovieByUrl(string url)
        {
            using (var client = new HttpClient())
            {
                var response = Task.Run(() => client.GetAsync(url)).Result;
                response.EnsureSuccessStatusCode();
                var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                var movie = JsonConvert.DeserializeObject<SWMovie>(result);
                return movie;
            }
        }
        public List<SWMovie> GetAllSWMovies()
        {
            string swapifilms = "http://swapi.co/api/films";
            var uri = new Uri(String.Format("{0}?format=json", swapifilms));
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(uri)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() =>
           response.Content.ReadAsStringAsync()).Result;
            var root =
           JsonConvert.DeserializeObject<RootObject<SWMovie>>(result);
            return root.results;
        }
        class RootObject<T>
        {
            public int count { get; set; }
            public object next { get; set; }
            public object previous { get; set; }
            public List<T> results { get; set; }
        }
    }
}