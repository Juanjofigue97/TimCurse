using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConnectionDBApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<ConecctionNames> ListConn = new List<ConecctionNames>();

            ListConn.Add(new ConecctionNames { ConnName = "MongoDb" });
            ListConn.Add(new ConecctionNames { ConnName = "MysqlDb" });
            ListConn.Add(new ConecctionNames { ConnName = "SQLDb" });

            //ConecctionNames.ItemsSource = ListConn;
        }
    }

    public class ConecctionNames
    {
        public string ConnName { get; set; }
    }
}
