using System.Windows;
using System.Windows.Controls;

namespace FiveMSettingsApp.Views
{
    public partial class AudioSettingsView : UserControl
    {
        public AudioSettingsView()
        {
            InitializeComponent();
            MasterVolumeSlider.ValueChanged += MasterVolumeSlider_ValueChanged;
        }

        private void MasterVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MasterVolumeLabel.Text = $"{(int)e.NewValue}%";
        }

        private void GameVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GameVolumeLabel.Text = $"{(int)e.NewValue}%";
        }

        private void VoiceVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VoiceVolumeLabel.Text = $"{(int)e.NewValue}%";
        }

        private void MicVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MicVolumeLabel.Text = $"{(int)e.NewValue}%";
        }

        private void TestAudioBtn_Click(object sender, RoutedEventArgs e)
        {
            // Play test sound
            try
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Audio test completed!", "Audio Test", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Could not play audio test", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TestMicBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Microphone recording for 3 seconds...\nThis is a placeholder for microphone testing.", 
                          "Microphone Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
