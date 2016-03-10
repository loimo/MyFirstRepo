using System.Windows;
using Model;
using WPFGridMVVMSelection.ServiceReference1;

namespace WPFGridMVVMSelection {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {

             //CalculatorClient client = new CalculatorClient();
             //double rt = client.Add(0.22, 0.33);



            InitializeComponent();
            DataContext = new ViewModel();
        }

    }
}
