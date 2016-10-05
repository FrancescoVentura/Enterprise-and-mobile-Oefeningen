using StarWarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverseClone.Services
{
    interface ISWDataService
    {
        List<SWMovie> GetAllSWMovies();
        List<SWPlanet> GetAllSWPlanet();
        SWResource GetSWMovieDetails(string uri);
    }
}
