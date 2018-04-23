using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextAction : ContentPage
	{
        private List<ContactData> myContacts;
        private ObservableCollection<ContactData> myCollection;

        ObservableCollection<ContactData> getContact(string searchText = null)
		{
			myContacts = new List<ContactData>
			{
				new ContactData {Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
				new ContactData {Name="Ai",Status="Absent",ImageUrl="http://lorempixel.com/100/100/people/2"},
				new ContactData {Name="Saeko",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
				new ContactData {Name="Sena",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}

			};
            if (String.IsNullOrWhiteSpace(searchText)){
                myCollection = new ObservableCollection<ContactData>(myContacts as List<ContactData>);
				return myCollection;
            }
            List<ContactData> result = myContacts.Where(c => c.Name.StartsWith(searchText)).ToList();

            myCollection = new ObservableCollection<ContactData>(result as List<ContactData>);

            return myCollection;
		}


		public ContextAction()
		{
			InitializeComponent();

			myListView.ItemsSource = getContact();
			myListView.EndRefresh();
			myListView.IsRefreshing = false;
		}

		private void Call_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as ContactData;
			DisplayAlert("Call", contact.Name, "OK");

		}

		private void Delete_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as ContactData;
            myCollection.Remove(contact);
			//myContacts.Remove(contact);
		}

		private void myListView_Refreshing(object sender, EventArgs e)
		{
			myListView.ItemsSource = getContact();
            myListView.EndRefresh();
		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			myListView.ItemsSource = getContact(e.NewTextValue);
		}
	}
}