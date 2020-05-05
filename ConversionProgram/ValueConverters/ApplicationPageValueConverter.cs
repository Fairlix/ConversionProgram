using ConversionProgram.Pages;
using System;
using System.Diagnostics;
using System.Globalization;

namespace ConversionProgram
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        /// <summary>
        /// Converts the page and return the according page
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropiate page
            switch ((ApplicationPage)value)
            {
                // Return Converterpage
                case ApplicationPage.Converter:
                    return new ConverterPage();

                // Return Calculatorpage
                case ApplicationPage.Calculator:
                    return new CalculatorPage();

                // Return Stopwatchtimerpage
                case ApplicationPage.StopwatchTimers:
                    return new StopwatchTimerPage();

                // Return Aboutpage
                case ApplicationPage.About:
                    return new AboutPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}