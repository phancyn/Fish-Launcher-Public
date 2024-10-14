using LaucnherYouTube.ChildWindow;
using System.Windows;

namespace LaucnherYouTube
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void StartUpArgumentsInitialMethod(object sender, StartupEventArgs e)
        {
            Splash splash = new Splash();
            if(e.Args.Length >= 1)
            {
                splash.SendersArgumentsTextBlock.Text += string.Join(" ; ", e.Args);
            }
            splash.Show();
        }
    }
}
