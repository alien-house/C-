using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExerciseNavigation
{
    public partial class FeedPage : ContentPage
	{
		private List<Activity> myActivity;
        public FeedPage()
        {
            InitializeComponent();
            myActivity = new List<Activity>
			{
				new Activity {UserId=1, Description="Your Facebook friend Jenny Daiby is on Istagram."},
				new Activity {UserId=2, Description="Jonv started following you"},
				new Activity {UserId=3, Description="RacheMartin liked your photo"},
				new Activity {UserId=4, Description="Your Facebook friend Bivan Jay is on Instagram."},
				new Activity {UserId=5, Description="SanaZ sent a photo posted by @brookeisep."},
				new Activity {UserId=6, Description="NextLab started following you."},
				new Activity {UserId=7, Description="Your Facebook friend Alex B is on Instagram."},
				new Activity {UserId=8, Description="Your Facebook friend Tara Chang is on Instagram"},
				new Activity {UserId=9, Description="Your Facebook friend Tom K is on Instagram."}

            };
            myListView.ItemsSource = myActivity;

		}

		private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var activityData = e.SelectedItem as Activity;

            //if (userData == null)
            //throw new ArgumentNullException();

            if (activityData != null)
			{
				Navigation.PushAsync(new UserProfilePage(activityData.UserId)
				//{
					//Title = "kawaran"
			    //}
                                    );
				myListView.SelectedItem = null;
            }

		}
    }
}
