using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Common;
using Techorama.Models;
using Techorama.Services;
using Techorama.Services.AzureAPI;
using Techorama.ViewModel;
using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class SpeakersPage : AbstractPage
    {
        public SpeakersPage()
        {
            InitializeComponent();
            getSpeakers();
        }

        private async void ItemTapped_Click(object sender, ItemTappedEventArgs e)
        {
            ListView listView = sender as ListView;
            Speaker speakerSelected = listView.SelectedItem as Speaker;
            if(CacheSessions.Instance.Sessions!=null)
            {
                List<Session> sessions = CacheSessions.Instance.Sessions;
                Session session = sessions.Where(x => x.Speaker == speakerSelected.Name).FirstOrDefault();
                await Navigation.PushAsync(new SpeakerDetailPage(speakerSelected, session));
            }
        }

        private async void getSpeakers()
        {
          
            //List<Speaker> speakers = await AzureService.GetSpeakers();
            List<Speaker> speakers = CacheSessions.Instance.Speakers;
            List <Session> sessions = CacheSessions.Instance.Sessions;
            List<Track> tracks = CacheSessions.Instance.Tracks;
            if(speakers==null)
            {
                CacheSessions.Instance.Speakers = await this.CallApiService(new GetSpeakersService()) as List<Speaker>;
                speakers = CacheSessions.Instance.Speakers;
            }
            if(tracks==null)
            {
                CacheSessions.Instance.Tracks = await this.CallApiService(new GetTracksService()) as List<Track>;
                tracks = CacheSessions.Instance.Tracks;
            }
            if (sessions == null)
            {
                CacheSessions.Instance.Sessions = await this.CallApiService(new GetSessionsService()) as List<Session>;
                sessions = CacheSessions.Instance.Sessions;
            }
           
            if (speakers!=null && sessions!=null)
            {
                (this.BindingContext as SpeakersViewModel).Speakers = new System.Collections.ObjectModel.ObservableCollection<Speaker>(speakers);
                (this.BindingContext as SpeakersViewModel).OriginalSpeakers = new System.Collections.ObjectModel.ObservableCollection<Speaker>(speakers);
            }

            if (tracks != null && sessions != null && speakers!=null)
            {
                setComponentLayout(tracks);
            }


        }

        private void setComponentLayout(List<Track> tracks)
        {
            List<string> tracksPicker = new List<string>();
            foreach(Track track in tracks)
            {
                tracksPicker.Add(track.Name);
            }
            this.pickerSlot.ItemsSource = tracksPicker;
            this.pickerSlot.SelectedIndex = -1;
            this.pickerSlot.SelectedIndexChanged += (sender, args) => {
                if (this.pickerSlot.SelectedIndex != -1 && !String.IsNullOrEmpty(this.pickerSlot.SelectedItem as string))
                {
                    (this.BindingContext as SpeakersViewModel).GetSpeakersBy(this.pickerSlot.SelectedItem as string, CacheSessions.Instance.Sessions);
                }
                else if(String.IsNullOrEmpty(this.pickerSlot.SelectedItem as string))
                {
                    (this.BindingContext as SpeakersViewModel).Speakers = new System.Collections.ObjectModel.ObservableCollection<Speaker>((this.BindingContext as SpeakersViewModel).OriginalSpeakers);
                }
            };
        }
    }
}
