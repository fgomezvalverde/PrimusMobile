using com.Goval.Mobile.Primus.Core.DependecyServices;
using com.Goval.Mobile.Primus.Model;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace com.Goval.Mobile.Primus.PageModels
{
    [ImplementPropertyChanged]
    public class DetailPostPageModel : FreshBasePageModel
    {
        public Post SelectedPost { get; set; }

        public Position PinLocation {
            get
            {
                return new Position (37.79752, -122.40183);
            }
        }
        public List<String> listaEjemplo {
            get { return new List<string> { "Lunes 18:00 - 22:00", "Martes 18:00 - 22:00", "Miercoles 18:00 - 22:00", "Jueves 18:00 - 22:00", "Viernes 18:00 - 22:00", "Sabado Cerrado", "Domingo 18:00 - 22:00" }; }
        }

        public override void Init(object initData)
        {
            if (initData != null)
            {
                SelectedPost = (Post)initData;
            }
            else
            {
                SelectedPost = new Post();
            }
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            NavigationPage.SetHasNavigationBar(sender as BindableObject, false);
            DependencyService.Get<IPlatformVIsualElements>().HideStatusBar();
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            NavigationPage.SetHasNavigationBar(sender as BindableObject, true);
            DependencyService.Get<IPlatformVIsualElements>().ShowStatusBar();
        }

        public Command ShareCommand
        {
            get
            {
                return new Command(async () => {
                    await CoreMethods.DisplayAlert("sistema", "sharing", "ok");
                });
            }
        }

        public Command FavoriteCommand
        {
            get
            {
                return new Command( () => {
                    if (SelectedPost.IsFavorite)
                        SelectedPost.IsFavorite = false;
                    else
                        SelectedPost.IsFavorite = true;
                    //await CoreMethods.DisplayAlert("sistema", "Favorite", "ok");
                });
            }
        }

        public Command LinkClicked
        { 
            get
            {
                return new Command<String>( (URL) => {
                    Device.OpenUri(new Uri(URL));
                });
            }
        }

    }
}
