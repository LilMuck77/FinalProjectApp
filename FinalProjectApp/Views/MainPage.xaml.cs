using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FinalProjectApp.Data;
using FinalProjectApp.Models;

namespace FinalProjectApp
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            listView.IsVisible = false;
            myDay.IsVisible = false;
        }

      

        private async void Monday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Monday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }


        private async void Tuesday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Tuesday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void Wednesday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Wednesday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void Thursday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Thursday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void Friday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Friday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void Saturday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = true;
            myDay.IsVisible = false;

            App.Day("Saturday");
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private void Sunday_Clicked(object sender, EventArgs e)
        {
            listView.IsVisible = false;
            myDay.Text = $"It's your day off. Relax and Enjoy!";
            myDay.IsVisible = true;
        }




        /* void OnSelection(object sender, SelectedItemChangedEventArgs e)
         {
             if (e.SelectedItem == null)
             {
                 return;
             }
             DaysOfTheWeek excersize = (DaysOfTheWeek)e.SelectedItem;
             DisplayAlert("Muscles Group", excersize.Excersize, "End Workout");
         }*/

        /*protected override async void OnAppearing()
        {


            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();

        }*/
    }
}
