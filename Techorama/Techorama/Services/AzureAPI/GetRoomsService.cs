using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;

namespace Techorama.Services.AzureAPI
{
    public class GetRoomsService : AzureService
    {
        public override async Task<object> CallService()
        {

            //var result = await Client.InvokeApiAsync<List<Room>>("Rooms", System.Net.Http.HttpMethod.Get, null);
            var result = GetLocalList();
            return result;

        }

        public override object GetLocalList()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room()
            {
                Name = "N1"
            });
            rooms.Add(new Room()
            {
                Name = "N2"
            });
            rooms.Add(new Room()
            {
                Name = "N3"
            });
            rooms.Add(new Room()
            {
                Name = "N4"
            });
            return rooms;
        }
    }
}
