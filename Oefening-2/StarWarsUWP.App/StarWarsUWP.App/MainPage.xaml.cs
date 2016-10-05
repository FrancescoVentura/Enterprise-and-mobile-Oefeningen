using StarWars.DAL;
using StarWarsUniverse.Model;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace StarWarsUWP.App
{

    public sealed partial class MainPage : Page
    {
        List<SWMovie> movieList;
        public MainPage()
        {
            this.InitializeComponent();

            SWAPIRepository sw = new SWAPIRepository();
            movieList = sw.GetAllSWMovies().OrderBy(s => s.Episode_ID).ToList();

            this.DataContext = movieList[0];
            EpisodeList.DataContext = movieList;
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            SWMovie sw = (SWMovie)DataContext;
            if (sw.Rating < 10)
            sw.Rating += 1;
        }

        private void downButton_Click_1(object sender, RoutedEventArgs e)
        {
            SWMovie sw = (SWMovie)DataContext;
            if (sw.Rating > 0)
                sw.Rating -= 1;
        }

        private void EpisodeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = EpisodeList.SelectedIndex;
            DataContext = movieList[index];
        }
    }
}
