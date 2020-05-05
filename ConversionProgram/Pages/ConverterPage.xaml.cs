using ConversionProgram.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ConversionProgram.Pages
{
    /// <summary>
    /// Interaction logic for ConverterPage.xaml
    /// </summary>
    public partial class ConverterPage : Page
    {
        public ConverterPage()
        {
            InitializeComponent();
            DataContext = new UnitConvertersVM();
        }

        #region Toolbar logic

        private void tbBtnCalculators_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
        }

        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            ToolBar toolBar = sender as ToolBar;
            var overflowGrid = toolBar.Template.FindName("OverflowGrid", toolBar) as FrameworkElement;
            if (overflowGrid != null)
            {
                overflowGrid.Visibility = Visibility.Collapsed;
            }
            var mainPanelBorder = toolBar.Template.FindName("MainPanelBorder", toolBar) as FrameworkElement;
            if (mainPanelBorder != null)
            {
                mainPanelBorder.Margin = new Thickness();
            }
        }

        #endregion Toolbar logic

        /// <summary>
        /// Updates property when enter is pressed when textbox is focussed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePropertyOnEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox tBox = (TextBox)sender;
                DependencyProperty prop = TextBox.TextProperty;

                BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null)
                {
                    binding.UpdateSource();
                }
            }
        }

        /// <summary>
        /// // Delete text in a textbox when textbox is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmptyTextBoxOn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            DependencyProperty prop = TextBox.TextProperty;

            BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
            if (binding != null)
            {
                tBox.Text = string.Empty;
                binding.UpdateSource();
            }
        }
    }
}