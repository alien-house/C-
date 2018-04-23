using Xamarin.Forms;

namespace Hello2
{
    public partial class Hello2Page : ContentPage
    {
        public Hello2Page()
        {
            InitializeComponent();

            // Other appraoch creating label
            //Content = new Label
            //{
            //    Text = "Hello World",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //slider1.Opacity = 0.5;

            if(Device.RuntimePlatform.Equals("iOS"))
            {
                Padding = new Thickness(0, 20, 0, 0);
            }else if(Device.RuntimePlatform.Equals("Android")){
                Padding = new Thickness(10, 20, 0, 0);
            }else if(Device.RuntimePlatform.Equals("Windows")){
                Padding = new Thickness(10, 20, 30, 0);
            }


        }
        private void clickbutton(object sender){
            DisplayAlert("Title", "Hello to xamarin.forms","OK");
        }
    }
}
