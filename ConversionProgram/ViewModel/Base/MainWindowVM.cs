using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ConversionProgram.Model;
using ConversionProgram.Pages;

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
        /// Start page upon loading the program
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Converter;

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

        public ICommand OpenConverterCommand { get; set; }

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
    }
}