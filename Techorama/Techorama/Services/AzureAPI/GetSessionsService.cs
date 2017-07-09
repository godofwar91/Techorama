using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;

namespace Techorama.Services.AzureAPI
{
    public class GetSessionsService : AzureService
    {
        public override async Task<object> CallService()
        {
            var result = await Client.InvokeApiAsync<List<Session>>("Sessions", System.Net.Http.HttpMethod.Get, null);
            return result;

        }
    }
}
