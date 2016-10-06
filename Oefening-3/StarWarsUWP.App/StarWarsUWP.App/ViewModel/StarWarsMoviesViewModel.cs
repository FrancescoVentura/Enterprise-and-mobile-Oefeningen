using StarWars.DAL;
using StarWarsUniverse.Model;
using StarWarsUWP.App.Extentions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.App.ViewModel
{
    public class StarWarsMoviesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<SWMovie> sWMovies;

        private SWAPIRepository movieDataService;
        public ObservableCollection<SWMovie> SWMovies
        {
            get { return sWMovies; }
            set
            {
                sWMovies = value;
                RaisePropertyChanged("SWMovies");
            }
        }

        private SWMovie selectMovie;

        public SWMovie SelectedMovie
        {
            get { return selectMovie; }
            set
            {
                selectMovie = value;
                RaisePropertyChanged("SelectedMovie");
            }
        }


        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public StarWarsMoviesViewModel()
        {
            movieDataService = new SWAPIRepository();
            LoadData();
        }

        private void LoadData()
        {
            SWMovies = movieDataService.GetAllSWMovies().ToObservableCollection();
        }
    }
}
