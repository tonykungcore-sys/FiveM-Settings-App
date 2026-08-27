using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Threading;

namespace FiveMSettingsApp.Views
{
    public partial class DashboardView : UserControl
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private DispatcherTimer updateTimer;

        public DashboardView()
        {
            InitializeComponent();
            InitializePerformanceCounters();
            StartUpdatingStats();
        }

        private void InitializePerformanceCounters()
        {
            try
            {
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
                ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", "", true);
            }
            catch
            {
                // Fallback if counters not available
            }
        }

        private void StartUpdatingStats()
        {
            updateTimer = new DispatcherTimer();
            updateTimer.Interval = System.TimeSpan.FromSeconds(1);
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, System.EventArgs e)
        {
            try
            {
                if (cpuCounter != null)
                {
                    float cpuUsage = cpuCounter.NextValue();
                    CPUValue.Text = $"{cpuUsage:F0}%";
                }

                if (ramCounter != null)
                {
                    float ramUsage = ramCounter.NextValue();
                    RAMValue.Text = $"{ramUsage:F0}%";
                }
            }
            catch
            {
                // Error handling
            }
        }
    }
}
