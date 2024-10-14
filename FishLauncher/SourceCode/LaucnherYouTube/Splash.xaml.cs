using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
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
using System.Windows.Shell;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace LaucnherYouTube
{
    /// <summary>
    /// Логика взаимодействия для Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        private readonly string _appPath = Process.GetCurrentProcess().MainModule.FileName;

        public Splash()
        {
            InitializeComponent();

            StartTimer();

            ColorGlowAnimation();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            var chrome = new WindowChrome
            {
                GlassFrameThickness = new Thickness(0),
                CornerRadius = new CornerRadius(20),
                ResizeBorderThickness = new Thickness(0),
                CaptionHeight = 0,
                UseAeroCaptionButtons = false
            };

            WindowChrome.SetWindowChrome(this, chrome);
        }

        //Анимация
        private void ColorGlowAnimation()
        {
            var colorAnimation = new ColorAnimation
            {
                From = Colors.Gray,
                To = Colors.DarkGray,
                Duration = TimeSpan.FromSeconds(0.5),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var solidColorBrush = new SolidColorBrush(Colors.White);
            YourImage.Effect = new System.Windows.Media.Effects.DropShadowEffect
            {
                Color = Colors.Blue,
                ShadowDepth = 0,
                BlurRadius = 10,
                Opacity = 1
            };

            YourImage.Effect = new System.Windows.Media.Effects.DropShadowEffect
            {
                Color = Colors.Aqua,
                ShadowDepth = 0,
                BlurRadius = 10,
                Opacity = 1
            };

            solidColorBrush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }

        #region Timer
        //Таймер для переключения окна на основной
        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5); // Устанавливаем интервал в 5 секунд
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DispatcherTimer timer = sender as DispatcherTimer;
            if (timer != null)
            {
                timer.Stop(); // Останавливаем таймер, чтобы он не срабатывал снова
                OpenMainWindow();
                this.Close(); // Закрываем текущее окно (если необходимо)
            }
        }
        private void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        #endregion

 
    }
}


