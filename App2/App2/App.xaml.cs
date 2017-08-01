using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class App : Application
    {
        private static DateTime? date;
        public static DateTime? Date {
            get {
                //return DateTime.Now;
                return null;
            }
            set
            {
                date = value;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new App2.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
