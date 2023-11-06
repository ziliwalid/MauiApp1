using MauiApp1.ViewModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public List<string> Mylist { get; set; }
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
           /* Mylist = new List<string>() {"walid", "stuff","toto","hello"};*/
            BindingContext = vm;
        }
        

    }
}