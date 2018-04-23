using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseList
{
    public class SearchService
	{
		//private IEnumerable<Search> mySearch;

		private List<Search> mySearchList = new List<Search>
		{
			new Search
			{
				Id = 1,
				Location = "West Hollywood, CA, United States",
				CheckIn = new DateTime(2016, 9, 1),
				CheckOut = new DateTime(2016, 11, 1)
			},
			new Search
			{
				Id = 2,
				Location = "Santa Monica, CA, United States",
				CheckIn = new DateTime(2016, 9, 1),
				CheckOut = new DateTime(2016, 11, 1)
			}
		};


        public IEnumerable<Search> getSearch(string filter = null)
		{
			if (String.IsNullOrWhiteSpace(filter))
				return mySearchList;
			return mySearchList.Where(c => c.Location.StartsWith(filter,StringComparison.CurrentCultureIgnoreCase));
		}

		public void DeleteSearch(int searchId)
		{
            mySearchList.Remove(mySearchList.Single(s => s.Id == searchId));

			//mySearch.Remove(search);
		}
    }
}
