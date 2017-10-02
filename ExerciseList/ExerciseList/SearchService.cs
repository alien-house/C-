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
    public class SearchService : IEnumerable
	{
		private IEnumerable<Search> mySearch;
        private List<Search> mySearchList;

        public SearchService()
        {
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Search> getSearch(string searchText = null)
		{
			mySearch = new List<Search>
			{
				new Search{Id=1, Location="West Hollywood, CA, United States", CheckIn=DateTime.Now, CheckOut=DateTime.Now},
				new Search{Id=2, Location="West2 Hollywood, CA, United States", CheckIn=DateTime.Now, CheckOut=DateTime.Now}
			};
			if (String.IsNullOrWhiteSpace(searchText))
				return mySearch;
			return mySearch.Where(c => c.Location.StartsWith(searchText)).ToList();
		}

		public void DeleteSearch(int searchId)
		{
            mySearchList = mySearch.ToList();

            foreach (Search s in mySearch)
            {
                if (searchId == s.Id)
                {
                    mySearchList.Remove(s);
                }
            }

			//mySearch.Remove(search);
		}
    }
}
