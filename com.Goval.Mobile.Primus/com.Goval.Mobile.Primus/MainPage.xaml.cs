using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using com.Goval.Mobile.Primus.Core.Amazon;
using com.Goval.Mobile.Primus.Model;

namespace com.Goval.Mobile.Primus
{
    public partial class MainPage : ContentPage
    {
        int cont = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Post obj = new Post
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = cont + ""
                };
                cont++;
                var name = DynamoDBManager.GetInstance();
                await DynamoDBManager.GetInstance().SaveAsync<Post>(obj);
                var lista = await DynamoDBManager.GetInstance().GetItemsAsync<Post>();

                Editor editor = this.FindByName<Editor>("Lista");
                editor.Text = lista.Count + "";
            }
            catch (Exception)
            {

                throw ;
            }
            
        }
    }
}
