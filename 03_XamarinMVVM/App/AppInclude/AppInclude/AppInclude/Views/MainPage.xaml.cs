using AppInclude.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInclude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel; 

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}