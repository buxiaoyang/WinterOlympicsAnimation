using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WinterOlympics
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //音乐地址
        Uri uriMusic = null;

        //刷新界面用定时器
        int timerCounter = 0;
        DispatcherTimer timer = new DispatcherTimer();

        //雪花
        List<Image> imageSnows = new List<Image>();
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            this.MouseDown += GridFrame_MouseDown;

            //添加雪花
            for (int i = 0; i < 26; i++)
            {
                Image image = new Image();
                image.VerticalAlignment = VerticalAlignment.Top;
                image.HorizontalAlignment = HorizontalAlignment.Left;
                image.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(new Uri(@"pack://application:,,,/Images/snow.png", UriKind.Absolute));
                image.Width = random.Next(30, 50);
                image.Height = image.Width;
                image.Margin = new Thickness(10 + (i % 13) * 80, random.Next(10, 700), 0, 0);
                RotateTransform rotateTransform = new RotateTransform(random.Next(0, 90));
                image.RenderTransform = rotateTransform;
                this.gridMain.Children.Add(image);
                imageSnows.Add(image);
            }

            //执行动作定时器
            timer.Tick += timerTick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0); //一秒执行一次
            timer.Start();

            //开始播放背景音乐
            if (File.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "music.mp3")))
            {
                uriMusic = new Uri(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "music.mp3"));
            }
            else
            {
                uriMusic = new Uri("http://home.buxiaoyang.com:88/demo/music.mp3");
            }
            mediaElement.Source = uriMusic;
            mediaElement.Play();

        }

        /// <summary>
        /// 移动窗口方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFrame_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    this.DragMove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("发生未知错误：\"{0}\"", ex.Message), "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void timerTick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter % 2 == 0)
            {
                this.ImageBanner.Margin = new Thickness(10, -5, 0, 0);
                this.ImageBingdundun.Margin = new Thickness(0, 0, 0, 10);
                RotateTransform rotateTransform = new RotateTransform(-5);
                this.ImageBingdundun.RenderTransform = rotateTransform;
            }
            else
            {
                this.ImageBanner.Margin = new Thickness(0, -5, 10, 0);
                this.ImageBingdundun.Margin = new Thickness(50, 0, 0, 25);
                RotateTransform rotateTransform = new RotateTransform(5);
                this.ImageBingdundun.RenderTransform = rotateTransform;
            }
            int position = timerCounter % 10;
            this.ImageSportsboy1.Margin = new Thickness(750 - (position * 45), 0, 0, 300 - (position * 34));
            RotateTransform rotateTransformSportboy = new RotateTransform(0 - position);
            this.ImageSportsboy1.RenderTransform = rotateTransformSportboy;
            //雪花
            foreach (Image image in imageSnows)
            {
                double marginTop = image.Margin.Top + 70;
                if (marginTop > 724)
                {
                    marginTop = marginTop - 724;
                }
                image.Margin = new Thickness(image.Margin.Left, marginTop, 0, 0);
                //RotateTransform rotateTransform = new RotateTransform(random.Next(0, 90));
                //image.RenderTransform = rotateTransform;
            }
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
