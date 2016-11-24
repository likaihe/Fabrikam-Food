using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Forms;
using Moodify.DataModels;

namespace Moodify
{
    public partial class PromotionPage : ContentPage
    {
        public PromotionPage()
        {
            InitializeComponent();
        }

        private async void TakePicture_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaliable.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front,
                Directory = "Moodify",
                Name = $"{DateTime.UtcNow}.jpg",
                CompressionQuality = 92
            });

            if (file == null)
                return;


            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/foods/1/") };
            image.Source = imageSource;
            //image.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }

        private void Share_Clicked(object sender, EventArgs e) {
            //code for share

            DisplayAlert("Share", "share Success", "Ok");
        }




    }
}
