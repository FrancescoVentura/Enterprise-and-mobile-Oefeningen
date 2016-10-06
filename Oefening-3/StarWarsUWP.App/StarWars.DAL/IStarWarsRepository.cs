using StarWarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.DAL
{
    interface IStarWarsRepository
    {
        SWMovie GetMovieByUrl(string url);
    }
}
