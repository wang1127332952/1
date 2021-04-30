using Hgtech.Control.Infrastructure.Constants;
using MahApps.Metro.Controls;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Input;

namespace Hgtech.Control.Shell.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //进行拖放移动
            this.DragMove();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void bgBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void maxBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            this.maxMinIcon.Text = this.WindowState == WindowState.Maximized ? "\xe62b" : "\xe65b";
        }
    }
}
