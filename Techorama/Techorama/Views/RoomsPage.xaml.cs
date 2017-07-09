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
    public partial class RoomsPage : AbstractPage
    {
        public RoomsPage()
        {
            InitializeComponent();

            getRooms();
        }

        private async void ItemTapped_Click(object sender, ItemTappedEventArgs e)
        {
            ListView listView = sender as ListView;
            Session sessionSelected = listView.SelectedItem as Session;
            if(sessionSelected!=null && !String.IsNullOrEmpty(sessionSelected.Description))
                await Navigation.PushAsync(new SessionDetailPage(sessionSelected.Title, sessionSelected.Description));
        }

        private async void getRooms()
        {
           
            //List<Room> rooms = await AzureService.GetRooms();
            List<Room> rooms = CacheSessions.Instance.Rooms;
            List<Session> sessions = CacheSessions.Instance.Sessions;
            if(rooms==null)
            {
                CacheSessions.Instance.Rooms = await this.CallApiService(new GetRoomsService()) as List<Room>;
                rooms = CacheSessions.Instance.Rooms;
            }
            if (sessions == null)
            {
                CacheSessions.Instance.Sessions = await this.CallApiService(new GetSessionsService()) as List<Session>;
                sessions = CacheSessions.Instance.Sessions;
            }

            if(rooms!=null && sessions!=null)
            {
                //popolamento
                (this.BindingContext as RoomsViewModel).SetGroupingRoomToSessions(rooms, sessions);
            }


        }
    }
}
