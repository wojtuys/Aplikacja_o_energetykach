using mvvmdwa.Model;
using mvvmdwa.ViewModel;

namespace mvvmdwa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new NapójViewModel();
        }

       
    }
}
