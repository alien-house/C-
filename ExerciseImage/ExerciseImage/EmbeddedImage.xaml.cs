using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExerciseImage
{
    public partial class EmbeddedImage : ContentPage
    {
        public EmbeddedImage()
        {
			InitializeComponent();
			image1.Source = ImageSource.FromResource("ExerciseImage.Image.beach.jpg");
        }
    }
}
