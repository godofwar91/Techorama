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
            //var result = await Client.InvokeApiAsync<List<Session>>("Sessions", System.Net.Http.HttpMethod.Get, null);
            var result = GetLocalList();
            return result;

        }

        public override Object GetLocalList()
        {
            List<Session> sessions = new List<Session>();
            sessions.Add(new Session()
            {
                Id = 1,
                Description = "Cross Platform",
                Start = new DateTime(2017, 05, 23, 9, 0, 0),
                End = new DateTime(2017, 05, 23, 10, 0, 0),
                Room = "N1",
                Speaker = "A.Jackson",
                Title = "Xamarin",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 2,
                Description = "Front end",
                Start = new DateTime(2017, 05, 23, 9, 0, 0),
                End = new DateTime(2017, 05, 23, 10, 0, 0),
                Room = "N2",
                Speaker = "B.Foerguson",
                Title = "Angular 5",
                Track = "Front end"
            });
            sessions.Add(new Session()
            {
                Id = 3,
                Description = ".NET Server",
                Start = new DateTime(2017, 05, 23, 9, 0, 0),
                End = new DateTime(2017, 05, 23, 10, 0, 0),
                Room = "N3",
                Speaker = "C.Huge",
                Title = "Asp. Net MVC",
                Track = "Back end"
            });
            sessions.Add(new Session()
            {
                Id = 4,
                Description = "Hadoop",
                Start = new DateTime(2017, 05, 23, 9, 0, 0),
                End = new DateTime(2017, 05, 23, 10, 0, 0),
                Room = "N4",
                Speaker = "D.Gulliver",
                Title = "Hadoop Spark",
                Track = "Big Data"
            });

            sessions.Add(new Session()
            {
                Id = 5,
                Description = "Machine Learning",
                Start = new DateTime(2017, 05, 23, 10, 0, 0),
                End = new DateTime(2017, 05, 23, 11, 0, 0),
                Room = "N1",
                Speaker = "D.Gulliver",
                Title = "Improve Machine Learning",
                Track = "Machine Learning"
            });
            sessions.Add(new Session()
            {
                Id = 6,
                Description = "Android Mobile",
                Start = new DateTime(2017, 05, 23, 10, 0, 0),
                End = new DateTime(2017, 05, 23, 11, 0, 0),
                Room = "N2",
                Speaker = "M.Kuyt",
                Title = "Android",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 7,
                Description = "Ios Mobile",
                Start = new DateTime(2017, 05, 23, 10, 0, 0),
                End = new DateTime(2017, 05, 23, 11, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Ios",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 8,
                Description = "F# Language",
                Start = new DateTime(2017, 05, 23, 10, 0, 0),
                End = new DateTime(2017, 05, 23, 11, 0, 0),
                Room = "N4",
                Speaker = "T.Yuliture",
                Title = "F# functional programming",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 9,
                Description = "Kotlin Language",
                Start = new DateTime(2017, 05, 23, 11, 0, 0),
                End = new DateTime(2017, 05, 23, 12, 0, 0),
                Room = "N1",
                Speaker = "T.Yuliture",
                Title = "Kotlin",
                Track = "Language"
            });
            sessions.Add(new Session()
            {
                Id = 10,
                Description = "Cross Platform",
                Start = new DateTime(2017, 05, 23, 11, 0, 0),
                End = new DateTime(2017, 05, 23, 12, 0, 0),
                Room = "N2",
                Speaker = "A.Jackson",
                Title = "React",
                Track = "Mobile Web"
            });
            sessions.Add(new Session()
            {
                Id = 11,
                Description = "Ios Mobile",
                Start = new DateTime(2017, 05, 23, 11, 0, 0),
                End = new DateTime(2017, 05, 23, 12, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Ios",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 12,
                Description = "Php 8 Language",
                Start = new DateTime(2017, 05, 23, 11, 0, 0),
                End = new DateTime(2017, 05, 23, 12, 0, 0),
                Room = "N4",
                Speaker = "S.Morgan",
                Title = "Php 8",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 13,
                Description = "Kotlin Android",
                Start = new DateTime(2017, 05, 23, 12, 0, 0),
                End = new DateTime(2017, 05, 23, 13, 0, 0),
                Room = "N1",
                Speaker = "K.luhutli",
                Title = "Kotlin Android",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 14,
                Description = "Bit coin",
                Start = new DateTime(2017, 05, 23, 12, 0, 0),
                End = new DateTime(2017, 05, 23, 13, 0, 0),
                Room = "N2",
                Speaker = "A.Morini",
                Title = "BlockChain",
                Track = "Bit coin"
            });
            sessions.Add(new Session()
            {
                Id = 15,
                Description = "Sql transaction",
                Start = new DateTime(2017, 05, 23, 12, 0, 0),
                End = new DateTime(2017, 05, 23, 13, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "T-Sql",
                Track = "DataBase"
            });
            sessions.Add(new Session()
            {
                Id = 16,
                Description = "Typescript Language",
                Start = new DateTime(2017, 05, 23, 12, 0, 0),
                End = new DateTime(2017, 05, 23, 13, 0, 0),
                Room = "N4",
                Speaker = "S.Stephenkins",
                Title = "Typescript",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 17,
                Description = "Xamarin Push Notification",
                Start = new DateTime(2017, 05, 23, 14, 0, 0),
                End = new DateTime(2017, 05, 23, 15, 0, 0),
                Room = "N1",
                Speaker = "K.luhutli",
                Title = "Xamarin Messages",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 18,
                Description = "Kotlin Spring",
                Start = new DateTime(2017, 05, 23, 14, 0, 0),
                End = new DateTime(2017, 05, 23, 15, 0, 0),
                Room = "N2",
                Speaker = "F.Murtens",
                Title = "Kotlin Spring",
                Track = "Back End"
            });
            sessions.Add(new Session()
            {
                Id = 19,
                Description = "Graph database social",
                Start = new DateTime(2017, 05, 23, 14, 0, 0),
                End = new DateTime(2017, 05, 23, 15, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Graph DataBase",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 20,
                Description = "Python 4",
                Start = new DateTime(2017, 05, 23, 14, 0, 0),
                End = new DateTime(2017, 05, 23, 15, 0, 0),
                Room = "N4",
                Speaker = "G.Jaykins",
                Title = "Python 4",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 21,
                Description = "Android Thing",
                Start = new DateTime(2017, 05, 23, 15, 0, 0),
                End = new DateTime(2017, 05, 23, 16, 0, 0),
                Room = "N1",
                Speaker = "M.Ginoli",
                Title = "Android Thing",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 22,
                Description = "Java 9",
                Start = new DateTime(2017, 05, 23, 15, 0, 0),
                End = new DateTime(2017, 05, 23, 16, 0, 0),
                Room = "N2",
                Speaker = "M.Fusco",
                Title = "Java 9",
                Track = "Language"
            });
            sessions.Add(new Session()
            {
                Id = 23,
                Description = "Document DB",
                Start = new DateTime(2017, 05, 23, 15, 0, 0),
                End = new DateTime(2017, 05, 23, 16, 0, 0),
                Room = "N3",
                Speaker = "F.Murtens",
                Title = "Mongo DB",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 24,
                Description = "Rust",
                Start = new DateTime(2017, 05, 23, 15, 0, 0),
                End = new DateTime(2017, 05, 23, 16, 0, 0),
                Room = "N4",
                Speaker = "G.Jaykins",
                Title = "Rust",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 25,
                Description = "Unity Game dev",
                Start = new DateTime(2017, 05, 23, 18, 0, 0),
                End = new DateTime(2017, 05, 23, 19, 0, 0),
                Room = "N1",
                Speaker = "Y.Ujackmins",
                Title = "Unity",
                Track = "Game Dev"
            });
            sessions.Add(new Session()
            {
                Id = 26,
                Description = "Tizen",
                Start = new DateTime(2017, 05, 23, 18, 0, 0),
                End = new DateTime(2017, 05, 23, 19, 0, 0),
                Room = "N2",
                Speaker = "J.kulyti",
                Title = "Tizen",
                Track = "Mobile Web Tv"
            });
            sessions.Add(new Session()
            {
                Id = 27,
                Description = "Column DB",
                Start = new DateTime(2017, 05, 23, 18, 0, 0),
                End = new DateTime(2017, 05, 23, 19, 0, 0),
                Room = "N3",
                Speaker = "F.Murtens",
                Title = "Cassandra",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 28,
                Description = "Scala",
                Start = new DateTime(2017, 05, 23, 18, 0, 0),
                End = new DateTime(2017, 05, 23, 19, 0, 0),
                Room = "N4",
                Speaker = "H.kilys",
                Title = "Scala",
                Track = "Language"
            });


            sessions.Add(new Session()
            {
                Id = 29,
                Description = "Cross Platform",
                Start = new DateTime(2017, 05, 24, 9, 0, 0),
                End = new DateTime(2017, 05, 24, 10, 0, 0),
                Room = "N1",
                Speaker = "A.Jackson",
                Title = "Xamarin-2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 30,
                Description = "Front end",
                Start = new DateTime(2017, 05, 24, 9, 0, 0),
                End = new DateTime(2017, 05, 24, 10, 0, 0),
                Room = "N2",
                Speaker = "B.Foerguson",
                Title = "Angular 5-2",
                Track = "Front end"
            });
            sessions.Add(new Session()
            {
                Id = 31,
                Description = ".NET Server",
                Start = new DateTime(2017, 05, 24, 9, 0, 0),
                End = new DateTime(2017, 05, 24, 10, 0, 0),
                Room = "N3",
                Speaker = "C.Huge",
                Title = "Asp. Net MVC -2",
                Track = "Back end"
            });
            sessions.Add(new Session()
            {
                Id = 32,
                Description = "Hadoop",
                Start = new DateTime(2017, 05, 24, 9, 0, 0),
                End = new DateTime(2017, 05, 24, 10, 0, 0),
                Room = "N4",
                Speaker = "D.Gulliver",
                Title = "Hadoop Spark -2",
                Track = "Big Data"
            });

            sessions.Add(new Session()
            {
                Id = 33,
                Description = "Machine Learning",
                Start = new DateTime(2017, 05, 24, 10, 0, 0),
                End = new DateTime(2017, 05, 24, 11, 0, 0),
                Room = "N1",
                Speaker = "D.Gulliver",
                Title = "Improve Machine Learning -2",
                Track = "Machine Learning"
            });
            sessions.Add(new Session()
            {
                Id = 34,
                Description = "Android Mobile",
                Start = new DateTime(2017, 05, 24, 10, 0, 0),
                End = new DateTime(2017, 05, 24, 11, 0, 0),
                Room = "N2",
                Speaker = "M.Kuyt",
                Title = "Android -2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 35,
                Description = "Ios Mobile",
                Start = new DateTime(2017, 05, 24, 10, 0, 0),
                End = new DateTime(2017, 05, 24, 11, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Ios -2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 36,
                Description = "F# Language",
                Start = new DateTime(2017, 05, 24, 10, 0, 0),
                End = new DateTime(2017, 05, 24, 11, 0, 0),
                Room = "N4",
                Speaker = "T.Yuliture",
                Title = "F# functional programming -2",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 37,
                Description = "Kotlin Language",
                Start = new DateTime(2017, 05, 24, 11, 0, 0),
                End = new DateTime(2017, 05, 24, 12, 0, 0),
                Room = "N1",
                Speaker = "T.Yuliture",
                Title = "Kotlin -2",
                Track = "Language"
            });
            sessions.Add(new Session()
            {
                Id = 38,
                Description = "Cross Platform",
                Start = new DateTime(2017, 05, 24, 11, 0, 0),
                End = new DateTime(2017, 05, 24, 12, 0, 0),
                Room = "N2",
                Speaker = "A.Jackson",
                Title = "React -2",
                Track = "Mobile Web"
            });
            sessions.Add(new Session()
            {
                Id = 39,
                Description = "Ios Mobile",
                Start = new DateTime(2017, 05, 24, 11, 0, 0),
                End = new DateTime(2017, 05, 24, 12, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Ios -2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 40,
                Description = "Php 8 Language",
                Start = new DateTime(2017, 05, 24, 11, 0, 0),
                End = new DateTime(2017, 05, 24, 12, 0, 0),
                Room = "N4",
                Speaker = "S.Morgan",
                Title = "Php 8 -2",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 41,
                Description = "Kotlin Android",
                Start = new DateTime(2017, 05, 24, 12, 0, 0),
                End = new DateTime(2017, 05, 24, 13, 0, 0),
                Room = "N1",
                Speaker = "K.luhutli",
                Title = "Kotlin Android",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 42,
                Description = "Bit coin",
                Start = new DateTime(2017, 05, 24, 12, 0, 0),
                End = new DateTime(2017, 05, 24, 13, 0, 0),
                Room = "N2",
                Speaker = "A.Morini",
                Title = "BlockChain -2",
                Track = "Bit coin"
            });
            sessions.Add(new Session()
            {
                Id = 43,
                Description = "Sql transaction",
                Start = new DateTime(2017, 05, 24, 12, 0, 0),
                End = new DateTime(2017, 05, 24, 13, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "T-Sql -2",
                Track = "DataBase"
            });
            sessions.Add(new Session()
            {
                Id = 44,
                Description = "Typescript Language",
                Start = new DateTime(2017, 05, 24, 12, 0, 0),
                End = new DateTime(2017, 05, 24, 13, 0, 0),
                Room = "N4",
                Speaker = "S.Stephenkins",
                Title = "Typescript -2",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 45,
                Description = "Xamarin Push Notification",
                Start = new DateTime(2017, 05, 24, 14, 0, 0),
                End = new DateTime(2017, 05, 24, 15, 0, 0),
                Room = "N1",
                Speaker = "K.luhutli",
                Title = "Xamarin Messages -2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 46,
                Description = "Kotlin Spring",
                Start = new DateTime(2017, 05, 24, 14, 0, 0),
                End = new DateTime(2017, 05, 24, 15, 0, 0),
                Room = "N2",
                Speaker = "F.Murtens",
                Title = "Kotlin Spring -2",
                Track = "Back End"
            });
            sessions.Add(new Session()
            {
                Id = 47,
                Description = "Graph database social",
                Start = new DateTime(2017, 05, 24, 14, 0, 0),
                End = new DateTime(2017, 05, 24, 15, 0, 0),
                Room = "N3",
                Speaker = "H.Lutyienne",
                Title = "Graph DataBase -2",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 48,
                Description = "Python 4",
                Start = new DateTime(2017, 05, 24, 14, 0, 0),
                End = new DateTime(2017, 05, 24, 15, 0, 0),
                Room = "N4",
                Speaker = "G.Jaykins",
                Title = "Python 4 -2",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 49,
                Description = "Android Thing",
                Start = new DateTime(2017, 05, 24, 15, 0, 0),
                End = new DateTime(2017, 05, 24, 16, 0, 0),
                Room = "N1",
                Speaker = "M.Ginoli",
                Title = "Android Thing -2",
                Track = "Mobile"
            });
            sessions.Add(new Session()
            {
                Id = 50,
                Description = "Java 9",
                Start = new DateTime(2017, 05, 24, 15, 0, 0),
                End = new DateTime(2017, 05, 24, 16, 0, 0),
                Room = "N2",
                Speaker = "M.Fusco",
                Title = "Java 9 -2",
                Track = "Language"
            });
            sessions.Add(new Session()
            {
                Id = 51,
                Description = "Document DB",
                Start = new DateTime(2017, 05, 24, 15, 0, 0),
                End = new DateTime(2017, 05, 24, 16, 0, 0),
                Room = "N3",
                Speaker = "F.Murtens",
                Title = "Mongo DB -2",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 52,
                Description = "Rust",
                Start = new DateTime(2017, 05, 24, 15, 0, 0),
                End = new DateTime(2017, 05, 24, 16, 0, 0),
                Room = "N4",
                Speaker = "G.Jaykins",
                Title = "Rust -2",
                Track = "Language"
            });

            sessions.Add(new Session()
            {
                Id = 53,
                Description = "Unity Game dev",
                Start = new DateTime(2017, 05, 24, 18, 0, 0),
                End = new DateTime(2017, 05, 24, 19, 0, 0),
                Room = "N1",
                Speaker = "Y.Ujackmins",
                Title = "Unity -2",
                Track = "Game Dev"
            });
            sessions.Add(new Session()
            {
                Id = 54,
                Description = "Tizen",
                Start = new DateTime(2017, 05, 24, 18, 0, 0),
                End = new DateTime(2017, 05, 24, 19, 0, 0),
                Room = "N2",
                Speaker = "J.kulyti",
                Title = "Tizen -2",
                Track = "Mobile Web Tv"
            });
            sessions.Add(new Session()
            {
                Id = 55,
                Description = "Column DB",
                Start = new DateTime(2017, 05, 24, 18, 0, 0),
                End = new DateTime(2017, 05, 24, 19, 0, 0),
                Room = "N3",
                Speaker = "F.Murtens",
                Title = "Cassandra -2",
                Track = "DataBase NoSql"
            });
            sessions.Add(new Session()
            {
                Id = 56,
                Description = "Scala",
                Start = new DateTime(2017, 05, 24, 18, 0, 0),
                End = new DateTime(2017, 05, 24, 19, 0, 0),
                Room = "N4",
                Speaker = "H.kilys",
                Title = "Scala -2",
                Track = "Language"
            });
            return sessions;
        }
    }
}
