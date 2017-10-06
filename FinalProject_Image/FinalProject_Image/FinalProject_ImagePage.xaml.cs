using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FinalProject_Image
{
    public partial class FinalProject_ImagePage : ContentPage
    {
        int maxNum = 0;
        public FinalProject_ImagePage()
        {
            InitializeComponent();

            //Grid  = new Grid();

			//gridLayout.Children.Add(new Label { Text = "00" }, 0, 0);
			//gridLayout.Children.Add(new Label { Text = "01" }, 0, 1);
			//gridLayout.Children.Add(new Label { Text = "10" }, 0, 2);
			//gridLayout.Children.Add(new Label { Text = "11" }, 1, 1);
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var images = await GetImageListAsync();
			int index = 1;
            int bend = 4;
			int row = 0;
			int column = 0;

			foreach (var photo in images.Photos)
			{
				var image = new Image
				{
					Source = ImageSource.FromUri(new Uri(photo))
				};


				TapGestureRecognizer imageTap = new TapGestureRecognizer();
				imageTap.Tapped += YourMethod;

				image.GestureRecognizers.Add(imageTap);



				Debug.WriteLine("row:{0}  column:{1}", column, row);
				gridLayout.Children.Add(image, column, row);
				column++;

				if(0 == index % bend){
                    row++;
                    column = 0;
				}
                index++;
			}
		}

        public void YourMethod(object sender, EventArgs args){
            Image img = sender as Image;
           
                Debug.WriteLine(img.Source);
            Navigation.PushAsync(new PicPage(img.Source));
        }


		async Task<ImageList> GetImageListAsync()
		{
			var requestUri = "http://alien-house.com/demo/stock.json";
			using (var client = new HttpClient())
			{
				var result = await client.GetStringAsync(requestUri);
                var resultC = JsonConvert.DeserializeObject<ImageList>(result);
                maxNum = resultC.Photos.Count;
				return JsonConvert.DeserializeObject<ImageList>(result);
			}
		}
    }
}
