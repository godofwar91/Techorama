using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;
using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class TechoramaMaster : ContentPage
    {

        public ListView listMI { get; set; }

        public TechoramaMaster()
        {
            InitializeComponent();
            SetComponentMaster();
        }

        private void SetComponentMaster()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Sessions",
                //IconSource = "contacts.png",
                TargetType = typeof(MainPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Rooms",
                //IconSource = "contacts.png",
                TargetType = typeof(RoomsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Speakers",
                //IconSource = "contacts.png",
                TargetType = typeof(SpeakersPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Tracks",
                //IconSource = "contacts.png",
                TargetType = typeof(TracksPage)
            });
            /* masterPageItems.Add(new MasterPageItem
             {
                 Title = "Weapons",
                 //IconSource = "todo.png",
                 //TargetType = typeof(CharacterDetail2Page)
             });*/


            this.listView.ItemsSource = masterPageItems;

            this.listMI = this.listView;

        }
    }
}
