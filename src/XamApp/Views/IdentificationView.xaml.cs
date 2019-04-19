using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IdentificationView : ContentPage
    {
        public IdentificationView()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged1(object sender, TextChangedEventArgs e)
        {
            EntryFrame1.BorderColor =Color.Black;
            NumEntry1.BackgroundColor = Color.Gainsboro;
            if (e.NewTextValue == "")
            {
                NumEntry1.BackgroundColor = Color.White;
                
            }
            else
            {
                NumEntry2.Focus(); 
            }
        }
        private void Entry_TextChanged2(object sender, TextChangedEventArgs e)
        {
            EntryFrame2.BorderColor = Color.Black;
            NumEntry2.BackgroundColor = Color.Gainsboro;
            if (e.NewTextValue == "")
            {
                NumEntry2.BackgroundColor = Color.White;
            }
            else
            {
                NumEntry3.Focus();
            }
        }
        private void Entry_TextChanged3(object sender, TextChangedEventArgs e)
        {
            EntryFrame3.BorderColor = Color.Black;
            NumEntry3.BackgroundColor = Color.Gainsboro;
            if (e.NewTextValue == "")
            {
                NumEntry3.BackgroundColor = Color.White;
            }
            else
            {
                NumEntry4.Focus();
            }
        }
        private void Entry_TextChanged4(object sender, TextChangedEventArgs e)
        {
            EntryFrame4.BorderColor = Color.Black;
            NumEntry4.BackgroundColor = Color.Gainsboro;
            if (e.NewTextValue == "")
            {
                NumEntry4.BackgroundColor = Color.White;
            }
        }
    }
}