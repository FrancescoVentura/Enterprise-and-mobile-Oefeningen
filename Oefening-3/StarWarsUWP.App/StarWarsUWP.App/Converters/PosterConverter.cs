using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace StarWarsUWP.App.Converters
{
    class PosterConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            String movieName = (String)value;
            String[] movieList = movieName.Split(' ');
            String fname = movieList[0];
            for (int i = 1; i < movieList.Length; i++)
            {
                fname = fname + "_" + movieList[i];
            }
            BitmapImage img = new BitmapImage();
            img.UriSource = new Uri("ms-appx:///Posters/"+fname+".jpg".ToLower());
            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
