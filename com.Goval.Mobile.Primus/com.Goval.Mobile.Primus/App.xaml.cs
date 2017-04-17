using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.Goval.Mobile.Primus.PageModels;
using Xamarin.Forms;
using com.Goval.Mobile.Primus.TESTTING;

namespace com.Goval.Mobile.Primus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //DataInitiliazerTest.AddCategoriesObjects();
            LoadTabbedNav();
            //MainPage = new MainPage();
        }

        public void LoadTabbedNav()
        {
            try
            {
                var tabbedNavigation = new FreshTabbedNavigationContainer();
                tabbedNavigation.AddTab<WeeklyEventsPageModel>("WEEK", null, null);
                tabbedNavigation.AddTab<CategoriesPageModel>("CATEGORIES", null, null);
                tabbedNavigation.AddTab<ProfilePageModel>("PROFILE", null, null);
                MainPage = tabbedNavigation;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void LoadFOTabbedNav()
        {
            var tabbedNavigation = new FreshTabbedFONavigationContainer("CRM");
            tabbedNavigation.AddTab<WeeklyEventsPageModel>("WEEK", null, null);
            tabbedNavigation.AddTab<CategoriesPageModel>("CATEGORIES", null, null);
            tabbedNavigation.AddTab<ProfilePageModel>("PROFILE", null, null);
            MainPage = tabbedNavigation;
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
