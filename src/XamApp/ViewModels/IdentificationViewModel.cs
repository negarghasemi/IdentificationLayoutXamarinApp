using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bit.ViewModel;
using Xamarin.Forms;

namespace XamApp.ViewModels
{
    public class IdentificationViewModel : BitViewModelBase
    {
        public Color EntryColor { get; set; }
        public BitDelegateCommand ApproveCommand { get; set; }

        public IdentificationViewModel()
        {
            ApproveCommand=new BitDelegateCommand(GoToSettings);
        }

        public async Task GoToSettings()
        {
            await NavigationService.NavigateAsync("/Nav/Setting");
        }
    }
}
