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
        private ObservableCollection<SearchGroup> groupedItems;
        //private List<Search> mySearch;
        private IEnumerable<Search> searchs;
        SearchService ss;

		public ExerciseListPage()
		{
			InitializeComponent();
            groupedItems = new ObservableCollection<SearchGroup>{};
            //SearchGroup sg = new SearchGroup("Recent Searches", "W");
            SearchGroup group = new SearchGroup("Recent Searches", "1");
            groupedItems.Add(group);

            ss = new SearchService();
            searchs = ss.getSearch();
			foreach (Search s in searchs)
			{
				group.Add(s);
			}

   //         myListView.ItemsSource = new List<SearchGroup>
   //         {
   //             new SearchGroup("Recent Searches","W")
   //             {
   //                 (ExerciseList.Search)ss.getSearch()
			//	}
			//};

			//mySearchGroup[0].Add((ExerciseList.Search)ss.getSearch());

			myListView.ItemsSource = groupedItems;
			myListView.EndRefresh();
			myListView.IsRefreshing = false;
		
        }

		private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var search = e.SelectedItem as Search;
            if(search != null){
                DisplayAlert("Location", search.Location, "OK");
            }
			myListView.SelectedItem = null;
		}

        private void myListView_Refreshing(object sender, EventArgs e)
        {
            //myListView.ItemsSource = (ExerciseList.Search)ss.getSearch();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //myListView.ItemsSource = getSearch(e.NewTextValue);
        }

		private void Delete_Clicked(object sender, EventArgs e)
		{

			//var menuItem = sender as MenuItem;
			//var search = menuItem.CommandParameter as Search;
			//ss.DeleteSearch(search.Id);


			var menuItem = sender as MenuItem;
			var search = menuItem.CommandParameter as Search;

            List<Search> mySearchList = searchs.ToList();
			mySearchList.Remove(search);
		}
	}
}
