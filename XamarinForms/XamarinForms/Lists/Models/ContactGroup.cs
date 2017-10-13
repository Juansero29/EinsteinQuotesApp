using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.Lists.Models
{
    class ContactGroup : ObservableCollection<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }

        public ContactGroup(IEnumerable<Contact> contacts, string title, string shortTitle)
        {
            foreach(Contact c in contacts)
            {
                Add(c);
            }
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
