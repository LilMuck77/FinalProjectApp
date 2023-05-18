using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalProjectApp.Data;
using FinalProjectApp.Models;

namespace FinalProjectApp
{

   
    public partial class App : Application
    {
       
       
        static PersonalItemDatabase database;
   
        
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void Day(String dayOfWeek)
        {
            
            if (dayOfWeek == "Monday")
            {
                database = new PersonalItemDatabase();
                mondayDatabase();
            }

            if (dayOfWeek == "Tuesday")
            {
                database = new PersonalItemDatabase();
                tuesdayDatabase();
            }
            if (dayOfWeek == "Wednesday")
            {
                database = new PersonalItemDatabase();
                wednesdayDatabase();
            }

            if (dayOfWeek == "Thursday")
            {
                database = new PersonalItemDatabase();
                thursdayDatabase();
            }
            if (dayOfWeek == "Friday")
            {
                database = new PersonalItemDatabase();
                fridayDatabase();
            }

            if (dayOfWeek == "Saturday")
            {
                database = new PersonalItemDatabase();
                saturdayDatabase();
            }
             
           


        }

        public static PersonalItemDatabase Database
        {
            get
            {

                if (database == null)
                {

           
                        //database = new PersonalItemDatabase();
                        //prefillDatabase();



                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

     
      
        static void mondayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Biceps", Exercise = "Concetration Curl", Sets = "4", Reps = "8 - 12" });

            database.InsertList(items);

        }

        static void tuesdayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Chest", Exercise = "Incline Dumbell Press", Sets = "5", Reps = "6 - 12" });

            database.InsertList(items);

        }
        static void wednesdayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Back", Exercise = "Pullups", Sets = "4", Reps = "5 - 15" });
             
            database.InsertList(items);

        }

        static void thursdayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Legs", Exercise = "Incline Leg Press", Sets = "5", Reps = "8 - 15" });

            database.InsertList(items);

        }
        static void fridayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Shoulders", Exercise = "Military Press", Sets = "4", Reps = "8 - 12" });

            database.InsertList(items);

        }
        static void saturdayDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { MuscleGroup = "Triceps", Exercise = "Dips", Sets = "4", Reps = "6 - 15" });

            database.InsertList(items);

        }
        

    }
}
