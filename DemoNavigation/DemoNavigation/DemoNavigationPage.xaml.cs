using System;
using System.Diagnostics.Contracts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation
{
    public partial class DemoNavigationPage : ContentPage
    {
        public DemoNavigationPage()
        {
            InitializeComponent();
        }

        public async void btnclicked(object sender, EventArgs e){
			//await Navigation.PushAsync(new DemoNavigation.Introduction());
            await Navigation.PushModalAsync(new DemoNavigation.Introduction());
        }

    }
}
