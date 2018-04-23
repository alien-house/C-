using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListView
{
    public class ContactGroup : List<ContactData>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }

		public ContactGroup(string title, string shorttitle)
		{
			Title = title;
			ShortTitle = shorttitle;
		}
    }
}
