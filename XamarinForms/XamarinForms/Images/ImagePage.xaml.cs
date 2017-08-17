using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            // var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://...")); //We need to explictly cast this into an UriImageSource

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7") }; // This syntax is cleaner and shorter.
            imageSource.CachingEnabled = false; //If enabled (which is by default) it will be kept in the device for 24 hours
            
            //imageSource.CacheValidity = TimeSpan.FromHours(1); // The default is 24 hours

            Image.Source = imageSource;
            Image.Aspect = Aspect.AspectFill; // Choose one out of the three possible 
        }
    }
}