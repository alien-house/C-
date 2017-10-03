using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfirmationBoxDemo
{
    public partial class EntryDemo : ContentPage
    {

        public EntryDemo()
        {
            InitializeComponent();
		}

		void Handle_Completed(object sender, System.EventArgs e)
		{
            myLabel.Text = "COMPLETED";
		}

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            myLabel.Text = e.NewTextValue;
        }
    }
}
