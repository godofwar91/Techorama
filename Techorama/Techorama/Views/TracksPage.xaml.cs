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
    public partial class TracksPage : AbstractPage
    {
        public TracksPage()
        {
            InitializeComponent();

            getTracks();
        }

        private async void ItemTapped_Click(object sender, ItemTappedEventArgs e)
        {
            ListView listView = sender as ListView;
            Session sessionSelected = listView.SelectedItem as Session;
            if(sessionSelected!=null && !String.IsNullOrEmpty(sessionSelected.Description))
                await Navigation.PushAsync(new SessionDetailPage(sessionSelected.Title, sessionSelected.Description));
        }

        private async void getTracks()
        {
            //List<Track> tracks = await AzureService.GetTracks();
            List<Track> tracks = CacheSessions.Instance.Tracks;
            List<Session> sessions = CacheSessions.Instance.Sessions;

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

            if (tracks != null && sessions != null)
            {
                //popolamento
                (this.BindingContext as TracksViewModel).SetGroupingTrackToSessions(tracks, sessions);
            }

        }
    }
}
