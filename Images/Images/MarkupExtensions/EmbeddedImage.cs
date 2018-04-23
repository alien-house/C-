using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Images.MarkupExtensions
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            
            if(String.IsNullOrWhiteSpace(ResourceId)){
                return null;
            }

            return ImageSource.FromResource(ResourceId);
			//"Images.Images.batdroid.png"
		}
    }
}
