using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms;

namespace XamarinForms.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecificPlatformPage : ContentPage
    {
        public SpecificPlatformPage()
        {
            InitializeComponent();

            btn.Image = (FileImageSource)ImageSource.FromFile(Helpers.GiveStringForThisDevice("clock.png", "clock.png", "Images/clock.png"));

           
        }
    }
}