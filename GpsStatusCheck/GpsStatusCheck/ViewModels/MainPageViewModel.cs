using GpsStatusCheck.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GpsStatusCheck.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private bool _isGpsEnable;
        public bool IsGpsEnable
        {
            get => _isGpsEnable;
            set => SetProperty(ref _isGpsEnable, value);
        }

        public ICommand CheckGpsStatusCommand { get; }

        public MainPageViewModel()
        {
            CheckGpsStatusCommand = new Command(OnCheckGpsStatus);
        }

        private void OnCheckGpsStatus()
        {
            IsGpsEnable = Xamarin.Forms.DependencyService.Get<IGpsDependencyService>().IsGpsEnable();

            if (!IsGpsEnable)
            {
                Xamarin.Forms.DependencyService.Get<IGpsDependencyService>().OpenSettings();
            }
        }
    }
}
