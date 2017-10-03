using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TableViewDemo
{
    public partial class ContactMethodPage : ContentPage
    {
        public ListView ContactMethod
        {
            get { return myListView; }
        }

        public ContactMethodPage()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<string>
            {
                "None",
                "Call",
                "Email",
                "Message",
                "WhatApp"
            };
        }
    }
}
