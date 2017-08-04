using AppInclude.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInclude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdicionarPage : ContentPage
    {
        private AdicionarViewModel ViewModel => BindingContext as AdicionarViewModel;

        public AdicionarPage()
        {
            InitializeComponent();
            BindingContext = new AdicionarViewModel();
        }
    }
}