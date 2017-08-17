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
    public partial class PhotoGallery : ContentPage
    {

        private int mCurrentImageIndex;

        private int CurrentImageIndex
        {
            get { if (mCurrentImageIndex == 0) return 1; else return mCurrentImageIndex%10; }
            set { mCurrentImageIndex = value; }
        }



        public PhotoGallery()
        {
            InitializeComponent();

            LeftButton.Image = (FileImageSource)ImageSource.FromFile(Helpers.GiveStringForThisDevice("left.png", "left.png", "Images/left.png"));
            RightButton.Image = (FileImageSource)ImageSource.FromFile(Helpers.GiveStringForThisDevice("right.png", "right.png", "Images/right.png"));
            UpdateImage();
        }

        private void LeftButton_Clicked(object sender, EventArgs e)
        {
            CurrentImageIndex++;
            UpdateImage();
        }

        private void RightButton_Clicked(object sender, EventArgs e)
        {
            CurrentImageIndex++;
            UpdateImage();
        }

        private void UpdateImage()
        {
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/" + CurrentImageIndex) };
            imageSource.CachingEnabled = false;
            Image.Source = imageSource;
        }
    }
}