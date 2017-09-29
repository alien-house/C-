using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo()
        {
			InitializeComponent();
			this.Children.Add(new DemoNavigationPage());
            this.Children.Add(new Contacts());

        }
    }
}
