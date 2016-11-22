using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Moodify
{
	public partial class HomePage : ContentPage
	{
        public HomePage()
		{
			InitializeComponent();
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("title", "hello", "ok");
        }
    }
}
