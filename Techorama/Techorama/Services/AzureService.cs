using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;
using Techorama.Services.AzureAPI;

namespace Techorama.Services
{
    public abstract class AzureService : IAzureOperationService
    {
        private const string MOBILESERVICECLIENTURL = "https://msft-xa-trm-api-euwe-prd.azurewebsites.net";

        public static MobileServiceClient Client;

        public AzureService()
        {
            Client = new MobileServiceClient(MOBILESERVICECLIENTURL);
        }

        public abstract Task<object> CallService();

        public abstract Object GetLocalList();


        /*public async static Task<List<Session>> GetSessions()
        {
            try
            {
                var result = await Client.InvokeApiAsync<List<Session>>("Sessions", System.Net.Http.HttpMethod.Get, null);
                return result;
            }
            catch (Exception err)
            {
                err.StackTrace.ToString();
            }
            return null;
        }

        public async static Task<List<Room>> GetRooms()
        {
            try
            {
                var result = await Client.InvokeApiAsync<List<Room>>("Rooms", System.Net.Http.HttpMethod.Get, null);
                return result;
            }
            catch (Exception err)
            {
                err.StackTrace.ToString();
            }
            return null;
        }

        public async static Task<List<Speaker>> GetSpeakers()
        {
            try
            {
                var result = await Client.InvokeApiAsync<List<Speaker>>("Speakers", System.Net.Http.HttpMethod.Get, null);
                return result;
            }
            catch (Exception err)
            {
                err.StackTrace.ToString();
            }
            return null;
        }

        public async static Task<List<Track>> GetTracks()
        {
            try
            {
                var result = await Client.InvokeApiAsync<List<Track>>("Tracks", System.Net.Http.HttpMethod.Get, null);
                return result;
            }
            catch (Exception err)
            {
                err.StackTrace.ToString();
            }
            return null;
        }*/
    }
}
