using UD5T2v2.MVVM.Views;

namespace UD5T2v2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
