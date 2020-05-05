using ConversionProgram.Pages;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace ConversionProgram.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// Setting the windows minimum width
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 920;

        /// <summary>
        /// Setting the windows minimum height
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 550;

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// The current page that is being displayed
        /// </summary>
        //public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Converter;

        private ApplicationPage _currentPage;

        /// <summary>
        /// The current page that is being displayed
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get { return _currentPage; }
            set
            {
                Set(ref _currentPage, value);
            }
        }

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        #region Commands

        /// <summary>
        /// The command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to show the system menu of the window
        /// </summary>
        public ICommand MenuCommand { get; set; }

        /// <summary>
        /// Command to always have the window on top
        /// </summary>
        public ICommand WindowAlwaysOnTopCommand { get; set; }

        /// <summary>
        /// Command to open the calculator page
        /// </summary>
        public ICommand OpenCalculatorPageCommand { get; set; }

        /// <summary>
        /// Command to open the converter page
        /// </summary>
        public ICommand OpenConverterPageCommand { get; set; }

        /// <summary>
        /// Command to open the stopwatch timer page
        /// </summary>
        public ICommand OpenStopwatchTimerPageCommand { get; set; }

        /// <summary>
        /// Command to open the about page
        /// </summary>
        public ICommand OpenAboutPageCommand { get; set; }

        #endregion Commands

        /// <summary>
        /// DEfault constructor
        /// </summary>
        /// <param name="window"></param>
        public MainWindowVM(Window window)
        {
            mWindow = window;

            // Create commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
            WindowAlwaysOnTopCommand = new RelayCommand(() => WindowAlwaysOnTop(window));
            OpenCalculatorPageCommand = new RelayCommand(() => OpenCalculatorPage());
            OpenConverterPageCommand = new RelayCommand(() => OpenConverterPage());
            OpenStopwatchTimerPageCommand = new RelayCommand(() => OpenStopwatchTimerPage());
            OpenAboutPageCommand = new RelayCommand(() => OpenAboutPage());
        }

        /// <summary>
        /// Opens calculator page
        /// </summary>
        private void OpenCalculatorPage()
        {
            // if currentPage doesn't equal CalculatorPage, open Calculator page
            if (CurrentPage != ApplicationPage.Calculator)
            {
                CurrentPage = ApplicationPage.Calculator;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Opens converter page
        /// </summary>
        private void OpenConverterPage()
        {
            if (CurrentPage != ApplicationPage.Converter)
            {
                CurrentPage = ApplicationPage.Converter;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Opens stopwatch timer page
        /// </summary>
        private void OpenStopwatchTimerPage()
        {
            if (CurrentPage != ApplicationPage.StopwatchTimers)
            {
                CurrentPage = ApplicationPage.StopwatchTimers;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Opens about page
        /// </summary>
        private void OpenAboutPage()
        {
            if (CurrentPage != ApplicationPage.About)
            {
                CurrentPage = ApplicationPage.About;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Gets the mouse position to relocate the window on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the window
            var position = Mouse.GetPosition(mWindow);

            // Add the window position so it's a "ToScreen"
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

        /// <summary>
        /// Method to keep window always on top when activated
        /// </summary>
        /// <param name="window"></param>
        private void WindowAlwaysOnTop(Window window)
        {
            // Checks if window is already on top, if not, it keeps it as topmost window
            if (window.Topmost != true)
            {
                window.Topmost = true;
            }
            // Checks if window is topmost, if true, set to default
            else if (window.Topmost == true)
            {
                window.Topmost = false;
            }
        }
    }
}