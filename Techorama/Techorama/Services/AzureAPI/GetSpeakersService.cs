using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;

namespace Techorama.Services.AzureAPI
{
    public class GetSpeakersService : AzureService
    {
        public override async Task<object> CallService()
        {
            var result = await Client.InvokeApiAsync<List<Speaker>>("Speakers", System.Net.Http.HttpMethod.Get, null);
            return result;
        }
    }
}
