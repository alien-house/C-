using System;
using Xamarin.Forms;

namespace Images
{
    public partial class ImagesPage : ContentPage
    {
        public ImagesPage()
        {
            InitializeComponent();
            var Imagesource = new UriImageSource{ Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            i1.Source = Imagesource;
            Imagesource.CachingEnabled = true;
        }
    }
}
