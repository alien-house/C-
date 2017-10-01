using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LAB3
{
    public partial class QuotesPage : ContentPage
	{
		string[] quotes = {
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"10.Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"20.Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"40.Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible",
				"You cant blame gravity for falling in love",
				"50.Nothing is impossible",
				"You cant blame gravity for falling in love",
				"Nothing is impossible"
			};

        public QuotesPage()
        {
            InitializeComponent();
            double top;
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					top = 40;
					break;
				case Device.Android:
					top = 30;
					break;
				case Device.WinPhone:
				case Device.Windows:
				default:
					top = 0;
					break;
			}
			Padding = new Thickness(20, top, 20, 20);

			//label_fontsize.Text = "Font size : " + slider1.Value.ToString();
            slider1.ValueChanged += HandleValueChanged;

		}
		
        void HandleValueChanged(object sender, EventArgs e)
		{   
			label_fontsize.Text = "Font size : " + slider1.Value.ToString("0");
            int num = int.Parse(slider1.Value.ToString("0")) - 16;
            label_quote.Text = this.quotes[num];
		}

    }
}
