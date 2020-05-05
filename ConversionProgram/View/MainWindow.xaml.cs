using ConversionProgram.Pages;
using ConversionProgram.ViewModel;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace ConversionProgram
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM(this);
        }

        #region Blurry background

        internal enum AccentState
        {
            ACCENT_DISABLED = 1,
            ACCENT_ENABLE_GRADIENT = 0,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        internal enum WindowCompositionAttribute
        {
            // ...
            WCA_ACCENT_POLICY = 19

            // ...
        }

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EnableBlur();
        }

        internal void EnableBlur()
        {
            var windowHelper = new WindowInteropHelper(this);

            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

            var accentStructSize = Marshal.SizeOf(accent);

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(windowHelper.Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        #endregion Blurry background

        //private void btnCalculators_Click(object sender, RoutedEventArgs e)
        //{
        //    // CalculatorPage calculatorPage = new CalculatorPage();
        //    // MainFrame.Navigate(calculatorPage);
        //}

        //private void btnConverters_Click(object sender, RoutedEventArgs e)
        //{
        //    ConverterPage converterPage = new ConverterPage();
        //    MainFrame.Navigate(converterPage);
        //}

        //private void btnStopwatchTimers_Click(object sender, RoutedEventArgs e)
        //{
        //    StopwatchTimerPage stopwatchTimerPage = new StopwatchTimerPage();
        //    MainFrame.Navigate(stopwatchTimerPage);
        //}

        //private void btnAbout_Click(object sender, RoutedEventArgs e)
        //{
        //    AboutPage aboutPage = new AboutPage();
        //    MainFrame.Navigate(aboutPage);
        //}
    }
}