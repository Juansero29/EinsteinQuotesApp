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
    public partial class EmbeddedImage : ContentPage
    {
        public EmbeddedImage()
        {
            InitializeComponent();
            //Image.Source = ImageSource.FromResource("XamarinForms.Resources.v2p0RVEAuVwqs.gif");
        }
    }
}