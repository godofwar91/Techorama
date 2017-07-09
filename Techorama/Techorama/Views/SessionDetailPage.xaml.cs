using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Techorama.Views
{
    public partial class SessionDetailPage : ContentPage
    {
        public SessionDetailPage(string title, string desc)
        {
            InitializeComponent();

            setLayout(title, desc);
        }

        private void setLayout(string title, string desc)
        {
            this.SessionTitle.Text = title;
            this.SessionDesc.Text = desc;
        }
    }
}
