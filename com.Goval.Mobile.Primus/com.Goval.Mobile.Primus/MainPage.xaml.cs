﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using com.Goval.Mobile.Primus.Core.Amazon;
using com.Goval.Mobile.Primus.Model;
using com.Goval.Mobile.Primus.Core.DependecyServices;

namespace com.Goval.Mobile.Primus
{
    public partial class MainPage : ContentPage
    {
        int cont = 1;
        public MainPage()
        {
            InitializeComponent();
            var list = this.FindByName<ListView>("LV");
            list.ItemsSource = Items;
        }
        public List<String> _items = new List<string> { "Lunes 18:00 - 22:00", "Martes 18:00 - 22:00", "Miercoles 18:00 - 22:00", "Jueves 18:00 - 22:00", "Viernes 18:00 - 22:00", "Sabado Cerrado", "Domingo 18:00 - 22:00" };
        public List<String> Items {
            get {
                return _items;
            }
            set {
                 _items = value;
            }
                }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //DependencyService.Get<IPlatformVIsualElements>().HideStatusBar();
        }
        private async void Button_ClickedModalNav(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushModalAsync(
                    new NavigationPage(new MainPage())
                    );
            }
            catch (Exception)
            {

                throw ;
            }
            
        }
        private async void Button_Clicked_PushNav(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(
                    new NavigationPage(new MainPage())
                    );
            }
            catch (Exception)
            {

                throw;
            }

        }
        private async void Button_Clicked_ModalNormal(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushModalAsync(
                   new MainPage()
                    );
            }
            catch (Exception)
            {

                throw;
            }

        }

        private async void Button_Clicked_Normal(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(
                   new MainPage()
                    );
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
