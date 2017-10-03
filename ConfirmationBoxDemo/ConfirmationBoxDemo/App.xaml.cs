using Xamarin.Forms;

namespace ConfirmationBoxDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			//MainPage = new ConfirmationBoxDemoPage();
			//MainPage = new ConfirmationBoxDemo.ActionSheet();
			//MainPage = new ConfirmationBoxDemo.SwitchDemo();
			//MainPage = new ConfirmationBoxDemo.SliderDemo();
			//MainPage = new ConfirmationBoxDemo.StepperDemo();
			//MainPage = new ConfirmationBoxDemo.EntryDemo();
			//MainPage = new ConfirmationBoxDemo.PickerDemo();
			MainPage = new ConfirmationBoxDemo.DatePickerDemo();




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
