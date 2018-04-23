using Xamarin.Forms;

namespace DemoListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			//MainPage = new DemoListViewPage();
			
            //MainPage = new DemoListView.CustomCellList();
			MainPage = new DemoListView.ContextAction();
			//MainPage = new DemoListView.Selection();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
