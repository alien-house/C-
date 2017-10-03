using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfirmationBoxDemo
{
    public partial class ActionSheet : ContentPage
    {
        public ActionSheet()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Contact Methods", "Cancel","Delete","Call","Message","Email","WhatsApp","Facebook");
            await DisplayAlert("Your ContactMethod", response, "OK");
        }
    }
}
