using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecificPlatformPage : ContentPage
    {
        public SpecificPlatformPage()
        {
            InitializeComponent();
            btn.Image = (FileImageSource) ImageSource.FromFile(Device.OnPlatform(
                iOS: "clock.png",
                Android: "clock.png",
                WinPhone: "Images/clock.png"
                ));
        }
    }
}