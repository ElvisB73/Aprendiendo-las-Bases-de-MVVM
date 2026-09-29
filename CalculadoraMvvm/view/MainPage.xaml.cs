using CalculadoraMvvm.viewmodels;
namespace CalculadoraMvvm
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new mainviewmodel();
        }

    }
}
