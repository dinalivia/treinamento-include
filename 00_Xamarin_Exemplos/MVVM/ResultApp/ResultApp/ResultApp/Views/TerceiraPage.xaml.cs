using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResultApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerceiraPage : ContentPage
    {
        public TerceiraPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.TerceiraViewModel();
        }
    }
}