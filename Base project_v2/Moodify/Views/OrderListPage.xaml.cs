using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Moodify.Views
{
    public partial class OrderListPage : ContentPage
    {
        public OrderListPage()
        {
            InitializeComponent();
        }

        private async void ViewTimeline_Clicked(Object sender, EventArgs e)
        {

            List<OrderList> oderLists = await AzureManager.AzureManagerInstance.GetOrderList();

            OrderListLayOut.ItemsSource = oderLists;

        }

        private void Delete_Clicked(Object sender, EventArgs e)
        {
            //Delete the order



            //if success out put below
            DisplayAlert("Order", "Delete Success", "Ok");

        }
    }
}
