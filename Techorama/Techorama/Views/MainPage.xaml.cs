using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Common;
using Techorama.Models;
using Techorama.Services;
using Techorama.Services.AzureAPI;
using Techorama.ViewModel;
using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class MainPage : AbstractPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);


            setComponentLayout();

                        
            getSessions();
        }

        private void setComponentLayout()
        {
            Dictionary<string, string> mapKeySlot = new Dictionary<string, string>()
            {
                {"09:00 - 13:00","9-13" }, {"13:00 - 17:00","13-17" }, {"17:00 - 21:00", "17-21"}
            };
            this.pickerSlot.ItemsSource = mapKeySlot.Keys.ToList();
            
            this.pickerSlot.SelectedIndex = -1;
            this.pickerSlot.SelectedIndexChanged += (sender, args)=> {
                if(this.pickerSlot.SelectedIndex != -1)
                {
                    string key = mapKeySlot[this.pickerSlot.SelectedItem as string];
                    (this.BindingContext as MainViewModel).filterBySlot(key);
                }
            };
            //datePickerFilter.Format = "dd-MM";
            //datePickerFilter.Date = new DateTime(2017, 5, 1);
            //datePickerFilter.MinimumDate = new DateTime(2017,5,23);
            //datePickerFilter.MaximumDate = new DateTime(2017,5,24);
            
            //this.timePickerFilter.
        }

        private async void getSessions()
        {

            List<Session> sessions = await this.CallApiService(new GetSessionsService()) as List<Session>;
            (this.BindingContext as MainViewModel).SetGroupingList(sessions);
            (this.BindingContext as MainViewModel).filterDate(new DateTime(2017, 5, 23));

        }

        
        private async void ItemTapped_Click(object sender, ItemTappedEventArgs e)
        {
            ListView listView = sender as ListView;
            Session sessionSelected = listView.SelectedItem as Session;
            if(sessionSelected!=null && !String.IsNullOrEmpty(sessionSelected.Description))
            {
                await Navigation.PushAsync(new SessionDetailPage(sessionSelected.Title, sessionSelected.Description));
            }
        }

        private void dateSelelected_Picker(object sender, DateChangedEventArgs args)
        {
            DatePicker dd = sender as DatePicker;
            (this.BindingContext as MainViewModel).filterDate(args.NewDate);
            //dd.Date
        }

        private void View24_Clicked(object sender, EventArgs args)
        {
            this.pickerSlot.SelectedIndex = -1;
            this.DayMonthText.Text = "24";
            (this.BindingContext as MainViewModel).filterDate(new DateTime(2017,5,24));
        }

        private void View23_Clicked(object sender, EventArgs args)
        {
            this.pickerSlot.SelectedIndex = -1;
            this.DayMonthText.Text = "23";
            (this.BindingContext as MainViewModel).filterDate(new DateTime(2017, 5, 23));
        }
    }
}
