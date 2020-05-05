using ConversionProgram.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ConversionProgram.Pages
{
    /// <summary>
    /// Interaction logic for CalculatorPage.xaml
    /// </summary>
    public partial class CalculatorPage : Page
    {
        public CalculatorPage()
        {
            InitializeComponent();
            DataContext = new CalculationsWindowVM();
        }

        #region Toolbar logic

        private void tbBtnConverters_Click(object sender, RoutedEventArgs e)
        {
            ConverterPage p = new ConverterPage();
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