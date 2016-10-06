using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsUWP.App.ViewModel;

namespace StarWarsUWP.App
{
    public class ViewModelLocator
    {
        private static StarWarsMoviesViewModel starWarsMoviesViewModel = new StarWarsMoviesViewModel();

        public static StarWarsMoviesViewModel StarWarsMoviesViewModel
        {
            get
            {
                return starWarsMoviesViewModel;
            }
        }
    }
}
