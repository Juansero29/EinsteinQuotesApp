using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms.Lists.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace XamarinForms.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<ContactGroup> _Contacts;

        public ListPage()
        {
            InitializeComponent();

            _Contacts = new ObservableCollection<ContactGroup>(GetContacts());

            listView.ItemsSource = _Contacts;
        }
        /*
         * Item is tapped when I tap on an item that is already selected
         */
        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }


        /*
         * Item is Selected when we have changed from one item to another.
         */
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            _Contacts = new ObservableCollection<ContactGroup>(GetContacts());
            listView.ItemsSource = _Contacts;
            listView.EndRefresh();
        }

        IEnumerable<ContactGroup> GetContacts(string searchText = null)
        {
            _Contacts = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("J", "J") {
                    new Contact { Name = "Jack", ImageURL = "http://lorempixel.com/100/100/people/3", Status="I'm Jack biaatch!"},
                    new Contact { Name = "Juan", ImageURL = "http://lorempixel.com/100/100/people/1", Status="I think I just got diarrhea!"}
                },
                new ContactGroup("M", "M")
                {
                    new Contact { Name = "Mosh", ImageURL = "http://lorempixel.com/100/100/people/2", Status="Hey! I'm awesome"}
                }
            };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return _Contacts.ToList();
            }

            var res = new List<ContactGroup>();

            for (int i = 0; i < _Contacts.Count; i++)
            {

                var contactRes = _Contacts[i].Where(c => c.Name.ToUpperInvariant().StartsWith(searchText.ToUpperInvariant()));
                res.Add(new ContactGroup(contactRes, _Contacts[i].Title, _Contacts[i].ShortTitle));
            }

            return res;

            //return _Contacts.Where(c => c.ToList().Where(ct => ct.Name.StartsWith(searchText)).Count() > 0);



        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            _Contacts = new ObservableCollection<ContactGroup>(GetContacts(e.NewTextValue));
            listView.ItemsSource = _Contacts;
        }
    }
}