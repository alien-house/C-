using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactData>{
                new ContactData {Name="Mitali",Status="Active"},
                new ContactData {Name="Mitali",Status="Active"},
                new ContactData {Name="Mitali",Status="Active"}
            };
        }
        public void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e){
            var Contact = e.SelectedItem as ContactData;
            Navigation.PushAsync(new Detail(Contact));
        }
    }
}
