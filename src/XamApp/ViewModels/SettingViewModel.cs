using System.Threading.Tasks;
using Bit.ViewModel;

namespace XamApp.ViewModels
{
    public class SettingViewModel : BitViewModelBase
    {
        public BitDelegateCommand GoBackCommand { get; set; }

        public SettingViewModel()
        {
            GoBackCommand= new BitDelegateCommand(GoToIdentification);
        }

        private async Task GoToIdentification()
        {
            await NavigationService.NavigateAsync("/Nav/Identification");
        }
    }
}
