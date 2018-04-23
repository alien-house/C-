using System;
using Xamarin.Forms;

namespace ExerciseImage
{
    public partial class ExerciseImagePage : ContentPage
	{
		private int _currentImageId = 1;
        public ExerciseImagePage()
        {
			InitializeComponent();
			_currentImageId = 1;

			LoadImage();

			//var ImageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/1") };
			//image1.Source = ImageSource;
			//ImageSource.CachingEnabled = false;

		}
		public void LoadImage()
		{
			image1.Source = new UriImageSource
			{
				Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _currentImageId)),
				CachingEnabled = false
			};
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			_currentImageId++;
			if (_currentImageId == 11)
				_currentImageId = 1;

			LoadImage();

		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			_currentImageId--;
			if (_currentImageId == 0)
				_currentImageId = 10;

			LoadImage();

		}
    }
}
