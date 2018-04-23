using System.Collections.Generic;
using Xamarin.Forms;

namespace DemoListView
{
    public partial class DemoListViewPage : ContentPage
    {
        public DemoListViewPage()
        {
            InitializeComponent();
			//var names = new List<string>{
			//    "koret",
			//    "resr",
			//    "komire"
			//};
			//myListView.ItemsSource = names;

			myListView.ItemsSource = new List<ContactData>
			{
				new ContactData {Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
				new ContactData {Name="Ai",Status="Absent",ImageUrl="http://lorempixel.com/100/100/people/2"},
				new ContactData {Name="Saeko",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
				new ContactData {Name="Sena",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}

			};

        }
    }
}
