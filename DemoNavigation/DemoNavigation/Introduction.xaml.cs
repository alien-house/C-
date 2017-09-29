using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class Introduction : ContentPage
    {
        public Introduction()
        {
            InitializeComponent();
		}

		public async void btnclicked(object sender, EventArgs e)
		{
			//await Navigation.PopAsync();
            await Navigation.PopModalAsync();
		}
    }
}
