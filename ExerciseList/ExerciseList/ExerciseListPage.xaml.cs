using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseList
{
    public partial class ExerciseListPage : ContentPage
	{
        private List<SearchGroup> groupedItems;
        //private List<Search> mySearch;
        //private IEnumerable<Search> searchs;
        private SearchService ss;

		public ExerciseListPage()
		{
            ss = new SearchService();
			InitializeComponent();

			PopulateListView(ss.getSearch());


            //groupedItems = new ObservableCollection<SearchGroup>{};
            //SearchGroup sg = new SearchGroup("Recent Searches", "W");
            //SearchGroup group = new SearchGroup("Recent Searches", "1");
            //groupedItems.Add(group);


   //         myListView.ItemsSource = new List<SearchGroup>
   //         {
   //             new SearchGroup("Recent Searches","W")
   //             {
   //                 (ExerciseList.Search)ss.getSearch()
			//	}
			//};

			//mySearchGroup[0].Add((ExerciseList.Search)ss.getSearch());

			//myListView.ItemsSource = groupedItems;
			//myListView.EndRefresh();
			//myListView.IsRefreshing = false;
		
        }

		private void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			PopulateListView(ss.getSearch(e.NewTextValue));
		}

		private void PopulateListView(IEnumerable<Search> searches)
		{
			groupedItems = new List<SearchGroup>
			{
				new SearchGroup("Recent Searches", searches)
			};

			myListView.ItemsSource = groupedItems;
		}

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
			//myListView.ItemsSource = getSearch(e.NewTextValue);
			PopulateListView(ss.getSearch(e.NewTextValue));
        }

		private void Delete_Clicked(object sender, EventArgs e)
		{

			//var menuItem = sender as MenuItem;
			//var search = menuItem.CommandParameter as Search;
			//ss.DeleteSearch(search.Id);


			var menuItem = sender as MenuItem;
			var search = menuItem.CommandParameter as Search;

            groupedItems[0].Remove(search);
            //List<Search> mySearchList = searchs.ToList();
            ss.DeleteSearch(search.Id);
		}

		private void myListView_Refreshing(object sender, EventArgs e)
		{
			//myListView.ItemsSource = (ExerciseList.Search)ss.getSearch();
            PopulateListView(ss.getSearch(searchBar.Text));
			myListView.EndRefresh();
		}

		private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var search = e.SelectedItem as Search;
			if (search != null)
			{
				DisplayAlert("Location", search.Location, "OK");
			}
			myListView.SelectedItem = null;
		}

	}
}
