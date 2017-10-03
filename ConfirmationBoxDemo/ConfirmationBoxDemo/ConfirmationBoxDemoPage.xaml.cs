using System;
using Xamarin.Forms;

namespace ConfirmationBoxDemo
{
    public partial class ConfirmationBoxDemoPage : ContentPage
    {

        public ConfirmationBoxDemoPage()
        {
            InitializeComponent();
        }

		// [async] we don wana to stop application. 
		private async void Handle_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "ok", "cancel");

            if(response){
                await DisplayAlert("Done", "your response is ok", "Ok");
			}
			else
			{
				await DisplayAlert("Done", "your response is cancel", "Ok");
            }

        }

    }
}
