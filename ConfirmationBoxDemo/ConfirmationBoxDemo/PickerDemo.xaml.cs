using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfirmationBoxDemo
{
    public partial class PickerDemo : ContentPage
    {
        public PickerDemo()
        {
            InitializeComponent();
        }

        public void Handle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMehod = myPicker.Items[myPicker.SelectedIndex];
            DisplayAlert("selectedMehod",selectedMehod,"OK");

        }
    }
}
