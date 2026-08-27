using System.Windows;
using System.Windows.Controls;
using FiveMSettingsApp.Views;

namespace FiveMSettingsApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadDashboard();
        }

        private void ApplicationsBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadApplications();
        }

        private void PowerplanBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPowerplan();
        }

        private void FiveMLauncherBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadFiveMLauncher();
        }

        private void AudioSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadAudioSettings();
        }

        private void GraphicsBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadGraphics();
        }

        private void GameSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadGameSettings();
        }

        private void NetworkBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadNetwork();
        }

        private void MotherboardBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadMotherboard();
        }

        private void LoadDashboard()
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(new DashboardView());
        }

        private void LoadApplications()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Applications Panel - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }

        private void LoadPowerplan()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Powerplan Settings - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }

        private void LoadFiveMLauncher()
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(new FiveMLauncherView());
        }

        private void LoadAudioSettings()
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(new AudioSettingsView());
        }

        private void LoadGraphics()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Graphics Settings - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }

        private void LoadGameSettings()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Game Settings - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }

        private void LoadNetwork()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Network Settings - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }

        private void LoadMotherboard()
        {
            ContentPanel.Children.Clear();
            var textBlock = new TextBlock
            {
                Text = "Motherboard Info - Coming Soon",
                Foreground = (System.Windows.Media.Brush)FindResource("TextColor"),
                FontSize = 24,
                Margin = new Thickness(20)
            };
            ContentPanel.Children.Add(textBlock);
        }
    }
}
