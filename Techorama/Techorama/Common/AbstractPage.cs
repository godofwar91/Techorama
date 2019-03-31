using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Services;
using Xamarin.Forms;

namespace Techorama.Common
{
    public class AbstractPage : ContentPage
    {

        private ActivityIndicator loader = null;
        private Image nowifi = null;

        private static string NAMEASSETNOWIFI = "no_wifi.png";

        public AbstractPage()
        {
            this.loader = getLoader();
            this.nowifi = getImageNoWifi();
        }

        #region Private Methods

        private void ShowLoading()
        {
            Grid root = this.Content as Grid;
            Grid.SetRow(loader, 0);
            Grid.SetRowSpan(loader, 2);
            root.Children.Add(loader);
            if (loader != null)
            {
                loader.IsVisible = true;
                loader.IsRunning = true;
            }
        }

        private void HideLoading()
        {
            Grid root = this.Content as Grid;

            if (loader != null)
            {
                loader.IsRunning = false;
                loader.IsVisible = false;
            }
            root.Children.Remove(loader);
        }

        private void ShowNoWifi()
        {
            Grid root = this.Content as Grid;
            Grid.SetRow(this.nowifi, 0);
            Grid.SetRowSpan(this.nowifi, 2);
            root.Children.Add(this.nowifi);
        }

        private ActivityIndicator getLoader()
        {
            ActivityIndicator loader = null;
            //Grid root = null;
            //root = this.Content as Grid;
            loader = new ActivityIndicator()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                IsVisible = false
            };
            if (Device.RuntimePlatform == Device.Windows)
            {
                loader.WidthRequest = 400;
                loader.Color = Color.Yellow;
            }
            else
            {
                loader.WidthRequest = 100;
            }
            /*Grid.SetRow(loader, 0);
            Grid.SetRowSpan(loader, 2);
            root.Children.Add(loader);*/
            return loader;
        }

        private Image getImageNoWifi()
        {
            Image nowifi = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 100,
                HeightRequest = 100,
                Aspect = Aspect.AspectFit
            };
            if (Device.RuntimePlatform == Device.Windows)
            {
                nowifi.Source = "Images/"+ NAMEASSETNOWIFI;
            }
            else
            {
                nowifi.Source = ImageSource.FromFile(NAMEASSETNOWIFI);
            }
            return nowifi;
        }

        #endregion

        #region Public Methods

        public async Task<object> CallApiService(IAzureOperationService service)
        {
            this.ShowLoading();

            var response = await AzureIntermediaryService.CallService(service);

            this.HideLoading();

            if(response==null)
            {
                this.ShowNoWifi();
            }
            return response;
        }

        #endregion

    }
}
