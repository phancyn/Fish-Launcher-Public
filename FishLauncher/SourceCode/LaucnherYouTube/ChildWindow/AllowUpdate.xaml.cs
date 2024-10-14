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
using System.Windows.Shapes;

namespace LaucnherYouTube.ChildWindow
{
    public partial class AllowUpdate : Window
    {
        public AllowUpdate()
        {
            InitializeComponent();
        }
        private void ButtonAllowUpdate(object sender, RoutedEventArgs e)
        {
            MainWindow.UserAllowUpdateApp = true;
            MainWindow.isActiveUpdateWindow = false;
            Close();
        }

        private void ButtonNoAllowUpdate(object sender, RoutedEventArgs e)
        {
            MainWindow.isActiveUpdateWindow = false;
            Close();
        }
    }
}
