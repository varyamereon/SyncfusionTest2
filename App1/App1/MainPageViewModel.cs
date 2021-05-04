using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class MainPageViewModel : BaseViewModel
    {
        private int? timeMinutes = null;
        public int? TimeMinutes
        {
            get => timeMinutes;
            set => SetProperty(ref timeMinutes, value);
        }

        public MainPageViewModel() => AutoCalculateCommand = new Command(AutoCalculate);

        public ICommand AutoCalculateCommand { get; }

        private void AutoCalculate()
        {
            TimeMinutes = 90;
        }
    }
}
