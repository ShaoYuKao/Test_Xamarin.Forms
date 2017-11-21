using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFDSDeviceID.Interfaces;

namespace XFDSDeviceID.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public string DeviceID { get; set; }
        IDevices _devices;

        public MainPageViewModel(INavigationService navigationService, IDevices devices )
        {
            _navigationService = navigationService;
            _devices = devices;

            DeviceID = _devices.GetID();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

    }

}
