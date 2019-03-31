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
            //var result = await Client.InvokeApiAsync<List<Speaker>>("Speakers", System.Net.Http.HttpMethod.Get, null);
            var result = GetLocalList();
            return result;
        }

        public override object GetLocalList()
        {
            List<Speaker> speakers = new List<Speaker>();
            speakers.Add(new Speaker()
            {
                Name = "A.Jackson"
            });
            speakers.Add(new Speaker()
            {
                Name = "B.Foerguson"
            });
            speakers.Add(new Speaker()
            {
                Name = "C.Huge"
            });
            speakers.Add(new Speaker()
            {
                Name = "D.Gulliver"
            });
            speakers.Add(new Speaker()
            {
                Name = "M.Kuyt"

            });
            speakers.Add(new Speaker()
            {
                Name = "H.Lutyienne"
            });
            speakers.Add(new Speaker()
            {
                Name = "T.Yuliture"
            });
            speakers.Add(new Speaker()
            {
                Name = "S.Morgan"
            });
            speakers.Add(new Speaker()
            {
                Name = "K.luhutli"
            });
            speakers.Add(new Speaker()
            {
                Name = "A.Morini"
            });
            speakers.Add(new Speaker()
            {
                Name = "S.Stephenkins"
            });
            speakers.Add(new Speaker()
            {
                Name = "F.Murtens"
            });
            speakers.Add(new Speaker()
            {
                Name = "G.Jaykins"
            });
            speakers.Add(new Speaker()
            {
                Name = "M.Ginoli"
            });
            speakers.Add(new Speaker()
            {
                Name = "M.Fusco"
            });
            speakers.Add(new Speaker()
            {
                Name = "Y.Ujackmin"
            });
            speakers.Add(new Speaker()
            {
                Name = "J.kulyti"
            });
            speakers.Add(new Speaker()
            {
                Name = "H.kilys"
            });

            return speakers;
        }
    }
}
