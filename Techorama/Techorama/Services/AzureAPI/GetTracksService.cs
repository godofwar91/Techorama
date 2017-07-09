using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;


namespace Techorama.Services.AzureAPI
{
    public class GetTracksService : AzureService
    {
        public override async Task<object> CallService()
        {

            var result = await Client.InvokeApiAsync<List<Track>>("Tracks", System.Net.Http.HttpMethod.Get, null);
            return result;

        }
    }
}
