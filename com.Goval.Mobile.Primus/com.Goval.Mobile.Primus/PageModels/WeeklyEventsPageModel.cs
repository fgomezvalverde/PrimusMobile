using com.Goval.Mobile.Primus.Core.Amazon;
using com.Goval.Mobile.Primus.Model;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace com.Goval.Mobile.Primus.PageModels
{
    [ImplementPropertyChanged]
    public class WeeklyEventsPageModel : FreshBasePageModel
    {
        public ObservableCollection<Event> WeeklyEvents { get; set; }

        public async override void Init(object initData)
        {
            var eventsList = await DynamoDBManager.GetInstance().GetItemsAsync<Event>();
            WeeklyEvents = new ObservableCollection<Event>(eventsList);
        }

        Event _selectedEvent;
        public Event SelectedEvent {
            get
            {
                return _selectedEvent;
            }
            set
            {
                _selectedEvent = value;
                if (value != null)
                    EventSelected.Execute(value);
            }
        } 

         public Command<Event> EventSelected
        {
             get
             {
                 return new Command<Event>(async (selected_Event) => {
                     await CoreMethods.PushPageModel<DetailPostPageModel>(selected_Event,true);

                     // Unselect the selectedItem, this change the style of selected item in GUI to nothing
                     var listView = this.CurrentPage.FindByName<ListView>("WeeklyListView");
                     listView.SelectedItem = null;
                 });

             }
         }
    }
}
