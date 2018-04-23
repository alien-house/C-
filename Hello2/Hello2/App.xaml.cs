using System.Diagnostics;
using Xamarin.Forms;

namespace Hello2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage = new Hello2Page();
			//MainPage = new Hello2.GreetPage2();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("de");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
