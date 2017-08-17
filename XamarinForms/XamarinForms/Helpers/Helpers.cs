using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms
{
    static class Helpers
    {
        public static string GiveStringForThisDevice(string Android, string iOS, string WinPhone)
        {
            string s;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    s = iOS;
                    break;
                case Device.Android:
                    s = Android;
                    break;
                case Device.WinPhone:
                    s = WinPhone;
                    break;
                default:
                    s = Android;
                    break;
            }
            return s;
        }
    }
}
