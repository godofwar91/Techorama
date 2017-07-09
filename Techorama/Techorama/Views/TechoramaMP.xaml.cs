using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;
using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class TechoramaMP : MasterDetailPage
    {
        public TechoramaMP()
        {
            InitializeComponent();
            setComponentMasterDetail();
        }

        private void setComponentMasterDetail()
        {
            TechoramaMaster masterPage = new TechoramaMaster();
            this.Master = masterPage;
            this.Detail = new NavigationPage(new MainPage());

            masterPage.listMI.SelectedItem = masterPage.listMI.ItemsSource.Cast<MasterPageItem>().ElementAt(0);
            masterPage.listMI.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                try
                {
                    //a prescindere, gli passo sempre l'item, poichè le 2 pagine vogliono sempre questo oggetto
                    var page = (Page)Activator.CreateInstance(item.TargetType);
                    /*if (Device.RuntimePlatform=="Android") //in Android è consentita una sola NavigationPage alla volta, e non una sotto un'altra già esistente all'inizio
                        Detail = page;
                    else
                        Detail = new NavigationPage(page);*/
                    //this.Master.ListView.SelectedItem = null;
                    Detail = new NavigationPage(page);
                }
                catch (Exception err)
                {
                    err.StackTrace.ToString();
                }
                finally
                {
                    IsPresented = false;
                }
            }
        }

    }
}
