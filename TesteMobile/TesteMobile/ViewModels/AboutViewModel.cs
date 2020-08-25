using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TesteMobile.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "GitHub";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/MatheusVi1ar"));
        }

        public ICommand OpenWebCommand { get; }
    }
}