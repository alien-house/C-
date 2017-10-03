using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TableViewDemo
{
    public partial class PickerWithNavigation : ContentPage
    {
        public PickerWithNavigation()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {


			var page = new ContactMethodPage();
			// MulticastDelegate ?
			page.ContactMethod.ItemSelected += (source, args) =>
			{
				System.Diagnostics.Debug.WriteLine("Debug.WriteLine による出力です");
				System.Diagnostics.Debug.WriteLine("ログ出力");
				data.Text = args.SelectedItem.ToString();
				Navigation.PopAsync();
			};
			Navigation.PushAsync(page);



            //Navigation.PushAsync(new ContactMethodPage());
            //throw new NotImplementedException();
        }

        //void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
