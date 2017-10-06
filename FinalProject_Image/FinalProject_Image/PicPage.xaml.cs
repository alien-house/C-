using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace FinalProject_Image
{
    public partial class PicPage : ContentPage
    {
        public PicPage(ImageSource imgs)
        {
			//Debug.WriteLine(imgs.Uri);
			BindingContext = imgs;
            InitializeComponent();
        }
    }
}
