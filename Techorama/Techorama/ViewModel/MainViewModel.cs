using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Techorama.Helpers;
using Techorama.Models;

namespace Techorama.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            this.Show24 = true;
        }

        private ObservableCollection<Grouping<String, Session>> _SessionsGrouping;
        public ObservableCollection<Grouping<String, Session>> SessionsGrouping
        {
            get { return _SessionsGrouping; }
            set
            {
                _SessionsGrouping = value;
                RaisePropertyChanged(() => SessionsGrouping);
            }
        }

        private ObservableCollection<Session> _Sessions;
        public ObservableCollection<Session> Sessions
        {
            get { return _Sessions; }
            set
            {
                _Sessions = value;
                RaisePropertyChanged(() => Sessions);
            }
        }

        private ObservableCollection<Session> _SessionsForADay;
        public ObservableCollection<Session> SessionsForADay
        {
            get { return _SessionsForADay; }
            set
            {
                _SessionsForADay = value;
                RaisePropertyChanged(() => SessionsForADay);
            }
        }

        private ObservableCollection<Session> _OriginalSessions;
        public ObservableCollection<Session> OriginalSessions
        {
            get { return _OriginalSessions; }
            set
            {
                _OriginalSessions = value;
                RaisePropertyChanged(() => OriginalSessions);
            }
        }

        private RelayCommand _Command;
        public RelayCommand Command
        {
            get
            {
                return _Command ?? (_Command = new RelayCommand(() =>
                {
                    this.Show24 = !this.Show24;
                    this.Show23 = !this.Show23;
                }));

            }
        }

        private bool _Show23;
        public bool Show23
        {
            get { return _Show23; }
            set
            {
                _Show23 = value;
                RaisePropertyChanged(() => Show23);
            }
        }

        private bool _Show24;
        public bool Show24
        {
            get { return _Show24; }
            set
            {
                _Show24 = value;
                RaisePropertyChanged(() => Show24);
            }
        }

        public void SetGroupingList(List<Session> sessions)
        {
            if(sessions!=null)
            {
                this.Sessions = new ObservableCollection<Session>(sessions);
                this.OriginalSessions = new ObservableCollection<Session>(sessions);
                this.SessionsForADay = new ObservableCollection<Session>(sessions);
            }
        }

        public void filterDate(DateTime date)
        {
            if(this.OriginalSessions!=null)
            {
                this.Sessions = new ObservableCollection<Session>(this.OriginalSessions.Where(x => x.Start.Day >= date.Day && x.End.Day<=date.Day).ToList());
                this.SessionsForADay = new ObservableCollection<Session>(this.OriginalSessions.Where(x => x.Start.Day >= date.Day && x.End.Day <= date.Day).ToList());
            }
        }

        public void filterBySlot(string slot)
        {
            if(this.OriginalSessions!=null)
            {
                int hourStart = int.Parse((slot.Split(new Char[] { '-' }))[0]);
                int hourEnd = int.Parse((slot.Split(new Char[] { '-' }))[1]);
                this.Sessions = new ObservableCollection<Session>(this.SessionsForADay.Where(x => x.Start.Hour >= hourStart && x.End.Hour<=hourEnd).ToList());

            }
        }

    }
}