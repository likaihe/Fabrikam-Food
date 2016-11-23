using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Moodify
{
    public partial class FabrikamManuPage : ContentPage
    {
        public FabrikamManuPage()
        {
            InitializeComponent();

        }

        private async void ViewTimeline_Clicked(Object sender, EventArgs e)
        {

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetMenus();

            MenuList.ItemsSource = menus;

        }

        private void Order_Clicked(Object sender, EventArgs e)
        {
            //need inptut userName and Tel then post the data to OerlistTable

           
            
            //if success out put below
            DisplayAlert("Order", "Success","Ok");

        }
    }
}
