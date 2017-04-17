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
    public class CategoriesPageModel : FreshBasePageModel
    {
        public ObservableCollection<Category> CATEGORIES { get; set; }

        public async override void Init(object initData)
        {
            var categoryList = await DynamoDBManager.GetInstance().GetItemsAsync<Category>();
            CATEGORIES = new ObservableCollection<Category>(categoryList);
        }

        public Command<Category> SelectedCategory
        {
            get
            {
                return new Command<Category>(async (selected_Category) => {
                    await CoreMethods.DisplayAlert("SISTEMA", selected_Category.Category_Name, "OK");
                    //await CoreMethods.PushPageModel<ContactPageModel>(contact);
                });
            }
        }
    }
}
