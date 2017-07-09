/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Techorama"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Techorama.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<RoomsViewModel>();
            SimpleIoc.Default.Register<SpeakersViewModel>();
            SimpleIoc.Default.Register<TracksViewModel>();
            SimpleIoc.Default.Register<SpeakerDetailViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public RoomsViewModel Rooms
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RoomsViewModel>();
            }
        }

        public SpeakersViewModel Speakers
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SpeakersViewModel>();
            }
        }

        public TracksViewModel Tracks
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TracksViewModel>();
            }
        }

        public SpeakerDetailViewModel SpeakerDetail
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SpeakerDetailViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}