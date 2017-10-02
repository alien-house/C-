using System;
using System.Collections.Generic;
namespace ExerciseList
{
    public class SearchGroup : List<Search>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }

		public SearchGroup(string title, string shorttitle)
		{
			Title = title;
			ShortTitle = shorttitle;
		}
    }
}
