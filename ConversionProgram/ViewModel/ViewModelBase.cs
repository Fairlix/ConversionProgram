using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConversionProgram.ViewModel
{
    /// <summary>
    /// Base class of every ViewModel Class
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged Event to raise to any UI object
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The PropertChangedEvent to rause to any UI object
        /// The Event is only invoked if data binding is used
        /// </summary>
        /// <param name="propertyName">The property name this is changing</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            // Grab a handler
            PropertyChangedEventHandler handler = this.PropertyChanged;

            // Only raise event if handler is connected
            if (handler != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                // Raise the PropertyChanged event.
                handler(this, args);
            }
        }

        protected bool Set<T>(ref T backingField, T value, [CallerMemberName] string propertyname = null)
        {
            // Check if the value and backing field are actualy different
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return false;
            }

            // Setting the backing field and the RaisePropertyChanged
            backingField = value;
            RaisePropertyChanged(propertyname);
            return true;
        }
    }
}