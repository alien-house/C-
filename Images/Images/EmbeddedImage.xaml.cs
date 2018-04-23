using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Images
{
    public partial class EmbeddedImage : ContentPage
    {
        public EmbeddedImage()
        {
            InitializeComponent();

            //var test = new Images.MarkupExtensions.EmbeddedImage();
            //myImage.Source = test.ProvideValue();

            // projectname . foldername . imagename
            myImage.Source = ImageSource.FromResource("Images.Images.batdroid.png");
        }
    }
}
