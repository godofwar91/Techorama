using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Techorama.Services
{
    public static class AzureIntermediaryService
    {
        public async static Task<object> CallService(IAzureOperationService service)
        {          
            try
            {
                var response = await service.CallService();
                return response;
            }
            catch(Exception err)
            {
                err.StackTrace.ToString();
            }
            return null;
           
        }     
    }
}
