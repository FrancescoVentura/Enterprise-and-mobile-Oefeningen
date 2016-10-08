using StarWars.DAL;
using StarWarsUniverse.Model;
using StarWarsUWP.App.Extentions;
using StarWarsUWP.App.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.App.ViewModel
{
    public class StarWarsMoviesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<SWMovie> sWMovies;

        public CustomCommand RateUpCommand { get; set; }

        public CustomCommand RateDownCommand { get; set; }

        public CustomCommand LoadCommand { get; set; }

        private void LoadCommands()
        {
            LoadCommand = new CustomCommand(Load, CanLoad);
            RateUpCommand = new CustomCommand(RateUp, CanRateUp);
            RateDownCommand = new CustomCommand(RateDown, CanRateDown);
        }

        private void Load(object obj)
        {
            SWMovies = movieDataService.GetAllSWMovies().OrderBy(s => s.Episode_ID).ToObservableCollection();
            selectMovie = SWMovies[0];
        }

        private bool CanLoad(object obj)
        {
            return true;
        }

        private void RateUp(object obj)
        {
            selectMovie.Rating += 1;
            RateDownCommand.RaiseCanExecuteChanged();
            RaisePropertyChanged("SelectedMovie");
        }

        private bool CanRateUp(object obj)
        {
            if (selectMovie != null)
                return selectMovie.Rating < 10;
            return true;
        }

        private void RateDown(object obj)
        {
            selectMovie.Rating -= 1;
            RateUpCommand.RaiseCanExecuteChanged();
            RaisePropertyChanged("SelectedMovie");
        }

        private bool CanRateDown(object obj)
        {
            if(selectMovie != null)
                return selectMovie.Rating > 0;
            return false;
        }

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
            LoadCommands();
        }
    }
}
