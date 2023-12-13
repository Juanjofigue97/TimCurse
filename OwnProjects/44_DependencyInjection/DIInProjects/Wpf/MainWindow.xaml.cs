using DIDemoLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMessages messages,IConfiguration config)
        {
            InitializeComponent();
            helloText.Text = messages.SayHello();
            goodbyeText.Text = messages.SayGoodbye();
            configText.Text = config.GetValue<string>("AppConfiguration");
        }
    }
}