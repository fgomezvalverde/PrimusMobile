using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.Goval.Mobile.Primus.PageModels;
using Xamarin.Forms;
using com.Goval.Mobile.Primus.TESTTING;
using Xamarin.Forms.Maps;

namespace com.Goval.Mobile.Primus
{
    public partial class App : Application
    { public static string Name= "WTF";
        public App()
        {
            InitializeComponent();
            /*TabbedPage tabPage = new TabbedPage();
            tabPage.Children.Add(new MainPage { Title="uno"});
            tabPage.Children.Add(new MainPage { Title = "dos" });
            MainPage = tabPage;*/
            //DataInitiliazerTest.AddCategoriesObjects();
            LoadTabbedNav();
            //MainPage = new MainPage();


            /*var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            ContentPage page = new ContentPage {  Content = stack};*/

            //MainPage = page;

        }

        public void LoadTabbedNav()
        {
            try
            {
                var tabbedNavigation = new FreshTabbedNavigationContainer();
                tabbedNavigation.AddTab<WeeklyEventsPageModel>("WEEK", null, null);
                tabbedNavigation.AddTab<CategoriesPageModel>("CATEGORIES", null, null);
                tabbedNavigation.AddTab<ProfilePageModel>("PROFILE", null, null);
                NavigationPage.SetHasNavigationBar(tabbedNavigation as BindableObject, false);
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
