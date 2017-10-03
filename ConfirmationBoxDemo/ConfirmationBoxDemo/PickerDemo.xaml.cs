using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfirmationBoxDemo
{

	class Contact
	{

		public string Name { get; set; }
		public int ID { get; set; }

	}

    public partial class PickerDemo : ContentPage
    {
        private IList<Contact> ContactMethod;

        public PickerDemo()
        {
            InitializeComponent();
            ContactMethod = GetContactMethod();
            foreach(var methods in ContactMethod){
                myPicker.Items.Add(methods.Name);
            }
        }

        private IList<Contact> GetContactMethod(){

			return new List<Contact>{
				new Contact { ID = 1, Name = "Call" },
                new Contact { ID = 2, Name = "Message" },
				new Contact { ID = 3, Name = "Email" },
				new Contact { ID = 4, Name = "WhatApp" },
				new Contact { ID = 4, Name = "KosApp" }
            };

        }
		
        public void Handle_SelectedIndexChanged(object sender, EventArgs e)
		{
            //Finding the selected object from picker control
            var index = myPicker.Items[myPicker.SelectedIndex];

			DisplayAlert("selectedMehod", index, "OK");

		}

        //public void Handle_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var selectedMehod = myPicker.Items[myPicker.SelectedIndex];
        //    DisplayAlert("selectedMehod",selectedMehod,"OK");

        //}
    }
}
