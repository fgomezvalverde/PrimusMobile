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
        public ObservableCollection<Event> WEEKLY_EVENTS { get; set; }

        public async override void Init(object initData)
        {
            var eventsList = await DynamoDBManager.GetInstance().GetItemsAsync<Event>();
            WEEKLY_EVENTS = new ObservableCollection<Event>(eventsList);
        }

        public Command<Event> SelectedEvents
        {
            get
            {
                return new Command<Event>(async (selected_Event) => {
                    await CoreMethods.DisplayAlert("SISTEMA", selected_Event.Name, "OK");
                    //await CoreMethods.PushPageModel<ContactPageModel>(contact);
                });
            }
        }
    }
}
