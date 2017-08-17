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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();


            //// I can also create a grid in code.

            //var grid = new Grid
            //{
            //    RowSpacing = 20,
            //    ColumnSpacing = 20
            //};

            //var label = new Label { Text = "Label 1" };
            ////left: how far from the left of the grid? 0 -> first column
            ////top: how far from the top of the grid? 0 -> firt row
            //grid.Children.Add(label, 0, 0);


            //// Static methods to assign rowspan and columnspan
            //Grid.SetRowSpan(label, 2);
            //Grid.SetColumnSpan(label, 2);

            ////We can also set a row/column to an element :

            ////Grid.SetRow(label, 0);
            ////Grid.SetColumn(label, 0);


            //// Setting rowdefinitions: 
            //grid.RowDefinitions.Add(new RowDefinition {
            //    Height = new GridLength(100, GridUnitType.Absolute)
            //});

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(2, GridUnitType.Star)
            //});

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(1, GridUnitType.Star)
            //});
        }
    }
}