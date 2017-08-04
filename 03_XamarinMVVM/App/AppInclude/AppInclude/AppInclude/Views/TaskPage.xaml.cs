using AppInclude.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInclude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : TabbedPage
    {
        private TaskViewModel ViewModel => BindingContext as TaskViewModel;

        public TaskPage()
        {
            InitializeComponent();

            BindingContext = new TaskViewModel();
        }
    }
}