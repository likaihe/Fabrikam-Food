﻿using Moodify.DataModels;
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

        private async void Order_Clicked(Object sender, EventArgs e)
        {
           
            //need inptut userName and Tel then post the data to OerlistTable
            string customer = "";
            
            string name = "";
            int tel = 000;
            string time = "";
            //get the value
            //name = sender.
            OrderList order = new OrderList {
                Customer = customer,
                Name = name,
                Tel = tel,
                Time = time
            };
            await AzureManager.AzureManagerInstance.AddOder(order);



            //if success out put below
           await DisplayAlert("Order", "Success","Ok");

        }
    }
}
