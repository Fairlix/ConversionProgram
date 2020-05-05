using ConversionProgram.ViewModel;
using System.Windows.Controls;

namespace ConversionProgram.Pages
{
    /// <summary>
    /// Interaction logic for StopwatchTimerPage.xaml
    /// </summary>
    public partial class StopwatchTimerPage : Page
    {
        public StopwatchTimerPage()
        {
            InitializeComponent();
            DataContext = new StopwatchTimersVM();
        }
    }
}