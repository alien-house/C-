using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class Detail : ContentPage
    {
        public Detail(ContactData contact)
        {
            if(contact == null){
                throw new ArgumentNullException();
            }

            BindingContext = contact;

            InitializeComponent();
        }
    }
}
