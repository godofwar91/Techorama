using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;
using Techorama.ViewModel;
using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class SpeakerDetailPage : ContentPage
    {
        public SpeakerDetailPage(Speaker speaker, Session session)
        {
            InitializeComponent();

            setLayout(speaker, session);
        }

        private  void setLayout(Speaker speaker, Session session)
        {
            if(speaker!=null)
            {
                this.Title = speaker.Name;

                if(!String.IsNullOrEmpty(speaker.AvatarUri))
                {
                    /*var imagen = new UriImageSource()
                    {
                        CachingEnabled = true,
                        Uri = new Uri(speaker.AvatarUri.Replace("https", "http")),
                     };

                    this.ImageAvatar.Source = imagen;*/


                    //this.ImageAvatar.Aspect = Aspect.AspectFill;
                    try
                    {
                        this.ImageAvatar.Source = ImageSource.FromUri(new Uri(speaker.AvatarUri));
                        //this.ImageAvatar.Source = ImageSource.FromUri(new Uri("http://myeuropassport.com/wp-content/uploads/2017/04/active-search-symbol.png"));
                    }
                    catch (Exception err)
                    {
                        err.StackTrace.ToString();
                    }
                }
                else
                {
                    this.ImageAvatar.WidthRequest = 0;
                    this.ImageAvatar.HeightRequest = 0;
                }

                this.locationText.Text = speaker.Location;
                this.siteText.Text = speaker.WebSiteUri;
                this.companyText.Text = speaker.Company;

                if (String.IsNullOrEmpty(speaker.Location))
                    this.ContainerLocation.IsVisible = false;
                if (String.IsNullOrEmpty(speaker.WebSiteUri))
                    this.ContainerSite.IsVisible = false;
                if (String.IsNullOrEmpty(speaker.Company))
                    this.ContainerCompany.IsVisible = false;

                this.BioText.Text = speaker.Bio;

                if (String.IsNullOrEmpty(speaker.Bio))
                    this.BioText.IsVisible = false;
                if (session != null)
                    (this.BindingContext as SpeakerDetailViewModel).Session = session;
                else
                    this.ContainerCourse.IsVisible = false;
            }
        }

        private void OnTapSite(object sender, EventArgs e)
        {
            Label label = sender as Label;
            string url = label.Text;
            if (url != null && (!url.StartsWith("http://") && !url.StartsWith("https://")))
                url = "http://" + url;
            Device.OpenUri(new Uri(url));
        }
    }
}
