using System.Diagnostics;
using Xamarin.Forms;

namespace ClassDemo
{
    public partial class ClassDemoPage : ContentPage
    {
        public ClassDemoPage()
        {
            InitializeComponent();

            test();
        }

        public void test(){

			Cat neko = new Cat("mike","mora");
			Debug.WriteLine(neko.Name);
			Debug.WriteLine("good bye");

			neko.Name = "kokokokoko";
			Debug.WriteLine(neko.Name);
        }
    }
}
