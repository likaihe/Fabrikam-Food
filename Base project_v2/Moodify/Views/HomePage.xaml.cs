
using System;
using System.Collections.Generic;
using Xamarin.Forms;

using Moodify.DataModels;

namespace Moodify
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private async void ViewTimeline_Clicked(Object sender, EventArgs e)
        {

            List<Timeline> timelines = await AzureManager.AzureManagerInstance.GetTimelines();

            TimelineList.ItemsSource = timelines;

        }
    }
}
