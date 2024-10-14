using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace LaucnherYouTube.ChildWindow
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        private void UnwrapApp_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void RollUpApp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.isActiveSettingWindow = false;
            Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) DragMove();
        }
        private void SubmitArgumentsButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ArgumentsAppString += TextBoxArgumentsPlayingProcess.Text;
            TextShowArgumentsDescription.Text += " ; " + MainWindow.ArgumentsAppString;
        }
        private int intArgumentsSpeedDownload;
        private void SubmitArgumentsDownloadSpeedLimitButton_Click(object sender, RoutedEventArgs e)
        {
            Color clrs = Color.FromRgb(0, 17, 68);
            if(int.TryParse(TextBoxArgumentsSpeedDownload.Text, out intArgumentsSpeedDownload) && intArgumentsSpeedDownload >= 1)
            {
                MainWindow.ArgumentsAppSpeedDownload = intArgumentsSpeedDownload;
                TextBoxArgumentsSpeedDownload.BorderBrush = new SolidColorBrush(clrs);
            }
            else
            {
                TextBoxArgumentsSpeedDownload.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }
    }
}