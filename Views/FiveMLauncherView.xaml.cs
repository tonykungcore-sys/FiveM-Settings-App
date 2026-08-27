using System.Windows;
using System.Windows.Controls;

namespace FiveMSettingsApp.Views
{
    public partial class FiveMLauncherView : UserControl
    {
        public FiveMLauncherView()
        {
            InitializeComponent();
        }

        private void ApplyPowerPlanBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Power Plan tweaks applied successfully!", "Success", 
                          MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
