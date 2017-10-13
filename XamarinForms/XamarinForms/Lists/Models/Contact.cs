using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.Lists.Models
{
    class Contact
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageURL { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
