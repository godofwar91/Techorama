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

            //var result = await Client.InvokeApiAsync<List<Track>>("Tracks", System.Net.Http.HttpMethod.Get, null);
            var result = GetLocalList();
            return result;

        }

        public override object GetLocalList()
        {
            List<Track> tracks = new List<Track>();
            tracks.Add(new Track()
            {
                Name = "Mobile"
            });
            tracks.Add(new Track()
            {
                Name = "Front end"
            });
            tracks.Add(new Track()
            {
                Name = "Back end"
            });
            tracks.Add(new Track()
            {
                Name = "Language"
            });
            tracks.Add(new Track()
            {
                Name = "Big Data"
            });
            tracks.Add(new Track()
            {
                Name = "Machine Learning"
            });
            tracks.Add(new Track()
            {
                Name = "Mobile Web"
            });
            tracks.Add(new Track()
            {
                Name = "Bit coin"
            });
            tracks.Add(new Track()
            {
                Name = "DataBase"
            });
            tracks.Add(new Track()
            {
                Name = "DataBase NoSql"
            });
            tracks.Add(new Track()
            {
                Name = "Game Dev"
            });
            tracks.Add(new Track()
            {
                Name = "Mobile Web Tv"
            });
            return tracks;
        }
    }
}
