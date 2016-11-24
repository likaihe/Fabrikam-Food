using Plugin.Settings;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;

namespace Moodify
{
    

    public partial class HomePage : ContentPage
    {
        bool authenticated = false;

        public HomePage()
        {
            InitializeComponent();
            var imageSource1 = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/food/1/") };
            var imageSource2 = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/foods/1/") };
           

            image1.Source = imageSource1;
            image2.Source = imageSource2;
           
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            string userId = CrossSettings.Current.GetValueOrDefault("user", "");
            string token = CrossSettings.Current.GetValueOrDefault("token", "");

            if (!token.Equals("") && !userId.Equals(""))
            {
                MobileServiceUser user = new MobileServiceUser(userId);
                user.MobileServiceAuthenticationToken = token;

                AzureManager.AzureManagerInstance.AzureClient.CurrentUser = user;

                authenticated = true;
            }

            if (authenticated == true)
                this.loginButton.IsVisible = false;
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            if (authenticated == true)
            {
                this.loginButton.IsVisible = false;
                CrossSettings.Current.AddOrUpdateValue("user", AzureManager.AzureManagerInstance.AzureClient.CurrentUser.UserId);
                CrossSettings.Current.AddOrUpdateValue("token", AzureManager.AzureManagerInstance.AzureClient.CurrentUser.MobileServiceAuthenticationToken);
            }
        }




    }
}
