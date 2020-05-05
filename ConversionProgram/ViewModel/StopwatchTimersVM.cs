using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace ConversionProgram.ViewModel
{
    public class StopwatchTimersVM : ViewModelBase
    {
        #region private members

        private Stopwatch FirstStopwatch = new Stopwatch();
        private string _firstStopwatchElapsedTime = "00:00:00:00";
        private ObservableCollection<string> _elapsedTimeFirstStopwatchList = new ObservableCollection<string>();

        private Stopwatch SecondStopwatch = new Stopwatch();
        private string _secondStopwatchElapsedTime = "00:000:00:00";
        private ObservableCollection<string> _elapsedTimeSecondStopwatchList = new ObservableCollection<string>();

        private Stopwatch ThirdStopwatch = new Stopwatch();
        private string _thirdStopwatchElapsedTime = "00:000:00:00";
        private ObservableCollection<string> _elapsedTimeThirdStopwatchList = new ObservableCollection<string>();

        private ObservableCollection<short> _hoursList = new ObservableCollection<short>();
        private ObservableCollection<short> _minutesList = new ObservableCollection<short>();
        private ObservableCollection<short> _secondsList = new ObservableCollection<short>();

        private short _selectedHourFirstTimer = 0;
        private short _selectedMinuteFirstTimer = 0;
        private short _selectedSecondFirstTimer = 0;
        private TimeSpan _timeSpanFirstTimer;
        private DispatcherTimer _dispatcherTimerFirstTimer;

        private short _selectedHourSecondTimer = 0;
        private short _selectedMinuteSecondTimer = 0;
        private short _selectedSecondSecondTimer = 0;
        private TimeSpan _timeSpanSecondTimer;
        private DispatcherTimer _dispatcherTimerSecondTimer;

        private short _selectedHourThirdTimer = 0;
        private short _selectedMinuteThirdTimer = 0;
        private short _selectedSecondThirdTimer = 0;
        private TimeSpan _timeSpanThirdTimer;
        private DispatcherTimer _dispatcherTimerThirdTimer;

        #endregion private members

        #region public properties

        #region Properties FirstStopwatch

        /// <summary>
        /// Property to save the elapsed time of FirstStopwatch
        /// </summary>
        public string FirstStopwatchElapsedTime
        {
            get
            {
                return _firstStopwatchElapsedTime;
            }

            set
            {
                Set(ref _firstStopwatchElapsedTime, value);
            }
        }

        public ObservableCollection<string> ElapsedTimeFirstStopwatchList
        {
            get { return _elapsedTimeFirstStopwatchList; }
            set
            {
                Set(ref _elapsedTimeFirstStopwatchList, value);
            }
        }

        #endregion Properties FirstStopwatch

        #region Properties SecondStopwatch

        /// <summary>
        /// Property to save the elapsed time of SecondStopwatch
        /// </summary>
        public string SecondStopwatchElapsedTime
        {
            get
            {
                return _secondStopwatchElapsedTime;
            }

            set
            {
                Set(ref _secondStopwatchElapsedTime, value);
            }
        }

        public ObservableCollection<string> ElapsedTimeSecondStopwatchList
        {
            get { return _elapsedTimeSecondStopwatchList; }
            set
            {
                Set(ref _elapsedTimeSecondStopwatchList, value);
            }
        }

        #endregion Properties SecondStopwatch

        #region Properties ThirdStopwatch

        /// <summary>
        /// Property to save the elapsed time of SecondStopwatch
        /// </summary>
        public string ThirdStopwatchElapsedTime
        {
            get
            {
                return _thirdStopwatchElapsedTime;
            }

            set
            {
                Set(ref _thirdStopwatchElapsedTime, value);
            }
        }

        public ObservableCollection<string> ElapsedTimeThirdStopwatchList
        {
            get { return _elapsedTimeThirdStopwatchList; }
            set
            {
                Set(ref _elapsedTimeThirdStopwatchList, value);
            }
        }

        #endregion Properties ThirdStopwatch

        #region Properties for Timers

        public ObservableCollection<short> HoursList
        {
            get { return _hoursList; }
            set
            {
                Set(ref _hoursList, value);
            }
        }

        public ObservableCollection<short> MinutesList
        {
            get { return _minutesList; }
            set
            {
                Set(ref _minutesList, value);
            }
        }

        public ObservableCollection<short> SecondsList
        {
            get { return _secondsList; }
            set
            {
                Set(ref _secondsList, value);
            }
        }

        #region Properties for FirstTimer

        public short SelectedHourFirstTimer
        {
            get { return _selectedHourFirstTimer; }
            set
            {
                Set(ref _selectedHourFirstTimer, value);
            }
        }

        public short SelectedMinuteFirstTimer
        {
            get { return _selectedMinuteFirstTimer; }
            set
            {
                Set(ref _selectedMinuteFirstTimer, value);
            }
        }

        public short SelectedSecondFirstTimer
        {
            get { return _selectedSecondFirstTimer; }
            set
            {
                Set(ref _selectedSecondFirstTimer, value);
            }
        }

        #endregion Properties for FirstTimer

        #region Properties for SecondTimer

        public short SelectedHourSecondTimer
        {
            get { return _selectedHourSecondTimer; }
            set
            {
                Set(ref _selectedHourSecondTimer, value);
            }
        }

        public short SelectedMinuteSecondTimer
        {
            get { return _selectedMinuteSecondTimer; }
            set
            {
                Set(ref _selectedMinuteSecondTimer, value);
            }
        }

        public short SelectedSecondSecondTimer
        {
            get { return _selectedSecondSecondTimer; }
            set
            {
                Set(ref _selectedSecondSecondTimer, value);
            }
        }

        #endregion Properties for SecondTimer

        #region Properties for ThirdTimer

        public short SelectedHourThirdTimer
        {
            get { return _selectedHourThirdTimer; }
            set
            {
                Set(ref _selectedHourThirdTimer, value);
            }
        }

        public short SelectedMinuteThirdTimer
        {
            get { return _selectedMinuteThirdTimer; }
            set
            {
                Set(ref _selectedMinuteThirdTimer, value);
            }
        }

        public short SelectedSecondThirdTimer
        {
            get { return _selectedSecondThirdTimer; }
            set
            {
                Set(ref _selectedSecondThirdTimer, value);
            }
        }

        #endregion Properties for ThirdTimer

        #endregion Properties for Timers

        #endregion public properties

        #region Commands

        public ICommand StartFirstStopwatchCommand { get; set; }
        public ICommand StopFirstStopwatchCommand { get; set; }
        public ICommand PauseFirstStopwatchCommand { get; set; }
        public ICommand ResetFirstStopwatchCommand { get; set; }
        public ICommand EmptyFirstStopWatchListCommand { get; set; }

        public ICommand StartSecondStopwatchCommand { get; set; }
        public ICommand StopSecondStopwatchCommand { get; set; }
        public ICommand PauseSecondStopwatchCommand { get; set; }
        public ICommand ResetSecondStopwatchCommand { get; set; }
        public ICommand EmptySecondStopWatchListCommand { get; set; }

        public ICommand StartThirdStopwatchCommand { get; set; }
        public ICommand StopThirdStopwatchCommand { get; set; }
        public ICommand PauseThirdStopwatchCommand { get; set; }
        public ICommand ResetThirdStopwatchCommand { get; set; }
        public ICommand EmptyThirdStopWatchListCommand { get; set; }

        public ICommand StartFirstTimerCommand { get; set; }
        public ICommand PauseFirstTimerCommand { get; set; }
        public ICommand StopFirstTimerCommand { get; set; }

        public ICommand StartSecondTimerCommand { get; set; }
        public ICommand PauseSecondTimerCommand { get; set; }
        public ICommand StopSecondTimerCommand { get; set; }

        public ICommand StartThirdTimerCommand { get; set; }
        public ICommand PauseThirdTimerCommand { get; set; }
        public ICommand StopThirdTimerCommand { get; set; }

        #endregion Commands

        #region Constructor

        /// <summary>
        /// Constructor, Intializing RelayCommands and Lists
        /// </summary>
        public StopwatchTimersVM()
        {
            // Relay commands to handle any task related to FirstStopwatch
            StartFirstStopwatchCommand = new RelayCommand(() => StartFirstStopwatch());
            StopFirstStopwatchCommand = new RelayCommand(() => StopFirstStopwatch());
            PauseFirstStopwatchCommand = new RelayCommand(() => PauseFirstStopwatch());
            ResetFirstStopwatchCommand = new RelayCommand(() => ResetFirstStopwatch());
            EmptyFirstStopWatchListCommand = new RelayCommand(() => EmptyFirstStopwatchList());

            // Relay commands to handle any task related to SecondStopwatch
            StartSecondStopwatchCommand = new RelayCommand(() => StartSecondStopwatch());
            StopSecondStopwatchCommand = new RelayCommand(() => StopSecondStopwatch());
            PauseSecondStopwatchCommand = new RelayCommand(() => PauseSecondStopwatch());
            ResetSecondStopwatchCommand = new RelayCommand(() => ResetSecondStopwatch());
            EmptySecondStopWatchListCommand = new RelayCommand(() => EmptySecondStopwatchList());

            // Relay commands to handle any task related to ThirdStopwatch
            StartThirdStopwatchCommand = new RelayCommand(() => StartThirdStopwatch());
            StopThirdStopwatchCommand = new RelayCommand(() => StopThirdStopwatch());
            PauseThirdStopwatchCommand = new RelayCommand(() => PauseThirdStopwatch());
            ResetThirdStopwatchCommand = new RelayCommand(() => ResetThirdStopwatch());
            EmptyThirdStopWatchListCommand = new RelayCommand(() => EmptyThirdStopwatchList());

            // Filling the HoursList with 0-24 hours
            for (short i = 0; i <= 99; i++)
            {
                HoursList.Add(i);
            }

            // Filling the MinutesList and SecondsList with 0-60 minutes
            for (short i = 0; i <= 60; i++)
            {
                MinutesList.Add(i);
                SecondsList.Add(i);
            }

            StartFirstTimerCommand = new RelayCommand(() => StartFirstTimer());
            PauseFirstTimerCommand = new RelayCommand(() => PauseFirstTimer());
            StopFirstTimerCommand = new RelayCommand(() => StopFirstTimer());

            StartSecondTimerCommand = new RelayCommand(() => StartSecondTimer());
            PauseSecondTimerCommand = new RelayCommand(() => PauseSecondTimer());
            StopSecondTimerCommand = new RelayCommand(() => StopSecondTimer());

            StartThirdTimerCommand = new RelayCommand(() => StartThirdTimer());
            PauseThirdTimerCommand = new RelayCommand(() => PauseThirdTimer());
            StopThirdTimerCommand = new RelayCommand(() => StopThirdTimer());
        }

        #endregion Constructor

        /// <summary>
        /// Dispatcher timer updating properties with the Stopwach elapsed time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Saving the elapsed time of FirstStopwatch
            TimeSpan timeSpan1 = FirstStopwatch.Elapsed;
            FirstStopwatchElapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan1.Hours, timeSpan1.Minutes, timeSpan1.Seconds, timeSpan1.Milliseconds / 10);

            // Saving the elapsed time of SecondStopwatch
            TimeSpan timeSpan2 = SecondStopwatch.Elapsed;
            SecondStopwatchElapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan2.Hours, timeSpan2.Minutes, timeSpan2.Seconds, timeSpan2.Milliseconds / 10);

            // Saving the elapsed time of ThirdStopwatch
            TimeSpan timeSpan3 = ThirdStopwatch.Elapsed;
            ThirdStopwatchElapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan3.Hours, timeSpan3.Minutes, timeSpan3.Seconds, timeSpan3.Milliseconds / 10);
        }

        #region Methods to control FirstStopWatch

        /// <summary>
        /// Starts the FirstStopwatch and a dispatcherTimer to fire <see cref="DispatcherTimer_Tick(object, EventArgs)"/>
        /// </summary>
        public void StartFirstStopwatch()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            FirstStopwatch.Start();
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Stops FirstStopwatch, resets its elapsed time and resets <see cref="FirstStopwatchElapsedTime"/>
        /// </summary>
        public void StopFirstStopwatch()
        {
            if (FirstStopwatch.IsRunning)
            {
                FirstStopwatch.Stop();
                TimeSpan timeSpan = FirstStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeFirstStopwatchList.Add(temporaryStorage);
                FirstStopwatch.Reset();
                FirstStopwatchElapsedTime = "00:00:00:00";
            }
            else if (!FirstStopwatch.IsRunning)
            {
                TimeSpan timeSpan = FirstStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeFirstStopwatchList.Add(temporaryStorage);
                FirstStopwatch.Reset();
                FirstStopwatchElapsedTime = "00:00:00:00";
            }
        }

        /// <summary>
        /// Pauses FirstStopwatch
        /// </summary>
        public void PauseFirstStopwatch()
        {
            if (FirstStopwatch.IsRunning)
            {
                FirstStopwatch.Stop();
            }
        }

        /// <summary>
        /// Resets FirstStopwatch and resets <see cref="FirstStopwatchElapsedTime"/>
        /// </summary>
        public void ResetFirstStopwatch()
        {
            FirstStopwatch.Reset();
            FirstStopwatchElapsedTime = "00:00:00:00";
        }

        public void EmptyFirstStopwatchList()
        {
            ElapsedTimeFirstStopwatchList.Clear();
        }

        #endregion Methods to control FirstStopWatch

        #region Methods to control SecondStopwatch

        /// <summary>
        /// Starts the SecondStopwatch and a dispatcherTimer to fire <see cref="DispatcherTimer_Tick(object, EventArgs)"/>
        /// </summary>
        public void StartSecondStopwatch()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            SecondStopwatch.Start();
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Stops SecondStopwatch, resets its elapsed time and resets <see cref="SecondStopwatchElapsedTime"/>
        /// </summary>
        public void StopSecondStopwatch()
        {
            if (SecondStopwatch.IsRunning)
            {
                SecondStopwatch.Stop();
                TimeSpan timeSpan = SecondStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeSecondStopwatchList.Add(temporaryStorage);
                SecondStopwatch.Reset();
                FirstStopwatchElapsedTime = "00:00:00:00";
            }
            else if (!SecondStopwatch.IsRunning)
            {
                TimeSpan timeSpan = SecondStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeFirstStopwatchList.Add(temporaryStorage);
                SecondStopwatch.Reset();
                SecondStopwatchElapsedTime = "00:00:00:00";
            }
        }

        /// <summary>
        /// Pauses SecondStopwatch
        /// </summary>
        public void PauseSecondStopwatch()
        {
            if (SecondStopwatch.IsRunning)
            {
                SecondStopwatch.Stop();
            }
        }

        /// <summary>
        /// Resets SecondStopwatch and resets <see cref="SecondStopwatchElapsedTime"/>
        /// </summary>
        public void ResetSecondStopwatch()
        {
            SecondStopwatch.Reset();
            SecondStopwatchElapsedTime = "00:00:00:00";
        }

        public void EmptySecondStopwatchList()
        {
            ElapsedTimeSecondStopwatchList.Clear();
        }

        #endregion Methods to control SecondStopwatch

        #region Methods to control ThirdStopwatch

        /// <summary>
        /// Starts the ThirdStopwatch and a dispatcherTimer to fire <see cref="DispatcherTimer_Tick(object, EventArgs)"/>
        /// </summary>
        public void StartThirdStopwatch()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            ThirdStopwatch.Start();
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Stops ThirdStopwatch, resets its elapsed time and resets <see cref="ThirdStopwatchElapsedTime"/>
        /// </summary>
        public void StopThirdStopwatch()
        {
            if (ThirdStopwatch.IsRunning)
            {
                ThirdStopwatch.Stop();
                TimeSpan timeSpan = ThirdStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeThirdStopwatchList.Add(temporaryStorage);
                ThirdStopwatch.Reset();
                FirstStopwatchElapsedTime = "00:00:00:00";
            }
            else if (!ThirdStopwatch.IsRunning)
            {
                TimeSpan timeSpan = ThirdStopwatch.Elapsed;
                string temporaryStorage = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
                ElapsedTimeThirdStopwatchList.Add(temporaryStorage);
                ThirdStopwatch.Reset();
                ThirdStopwatchElapsedTime = "00:00:00:00";
            }
        }

        /// <summary>
        /// Pauses ThirdStopwatch
        /// </summary>
        public void PauseThirdStopwatch()
        {
            if (ThirdStopwatch.IsRunning)
            {
                ThirdStopwatch.Stop();
            }
        }

        /// <summary>
        /// Resets ThirdStopwatch and resets <see cref="ThirdStopwatchElapsedTime"/>
        /// </summary>
        public void ResetThirdStopwatch()
        {
            ThirdStopwatch.Reset();
            ThirdStopwatchElapsedTime = "00:00:00:00";
        }

        public void EmptyThirdStopwatchList()
        {
            ElapsedTimeThirdStopwatchList.Clear();
        }

        #endregion Methods to control ThirdStopwatch

        #region Methods to control FirstTimer

        /// <summary>
        /// Starting the timer, counting down in seconds
        /// </summary>
        private void StartFirstTimer()
        {
            /// Adding Hours, Minutes and Seconds as totalSeconds
            int _totalSecondsFirstTimer = ((int)SelectedHourFirstTimer * 3600) + ((int)SelectedMinuteFirstTimer * 60) + (int)SelectedSecondFirstTimer;

            _timeSpanFirstTimer = TimeSpan.FromSeconds(_totalSecondsFirstTimer);

            // Creating a dispatcher timer which stops when zero, counting down in seconds intervals
            _dispatcherTimerFirstTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
              {
                  // If dispatcher timer equals zero > stop timer
                  if (_timeSpanFirstTimer == TimeSpan.Zero)
                  {
                      _dispatcherTimerFirstTimer.Stop();
                      MessageBox.Show("Timer Down");
                  }
                  // Add combobox updates here
                  SelectedHourFirstTimer = (short)_timeSpanFirstTimer.Hours;
                  SelectedMinuteFirstTimer = (short)_timeSpanFirstTimer.Minutes;
                  SelectedSecondFirstTimer = (short)_timeSpanFirstTimer.Seconds;

                  // Substracts 1 second from timer
                  _timeSpanFirstTimer = _timeSpanFirstTimer.Add(TimeSpan.FromSeconds(-1));
              },
              App.Current.Dispatcher);
            _dispatcherTimerFirstTimer.Start();
        }

        /// <summary>
        /// Pauses the first timer
        /// </summary>
        private void PauseFirstTimer()
        {
            _dispatcherTimerFirstTimer.Stop();
        }

        /// <summary>
        /// Stops the first timer
        /// </summary>
        private void StopFirstTimer()
        {
            // Stopping the dispatcher timer
            _dispatcherTimerFirstTimer.Stop();

            // Resets the timer
            _timeSpanFirstTimer = TimeSpan.Zero;
            SelectedHourFirstTimer = 0;
            SelectedMinuteFirstTimer = 0;
            SelectedSecondFirstTimer = 0;
        }

        #endregion Methods to control FirstTimer

        #region Methods to control SecondTimer

        /// <summary>
        /// Starting the timer, counting down in seconds
        /// </summary>
        private void StartSecondTimer()
        {
            /// Adding Hours, Minutes and Seconds as totalSeconds
            int _totalSecondsSecondTimer = ((int)SelectedHourSecondTimer * 3600) + ((int)SelectedMinuteSecondTimer * 60) + (int)SelectedSecondSecondTimer;

            _timeSpanSecondTimer = TimeSpan.FromSeconds(_totalSecondsSecondTimer);

            // Creating a dispatcher timer which stops when zero, counting down in seconds intervals
            _dispatcherTimerSecondTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                // If dispatcher timer equals zero > stop timer
                if (_timeSpanSecondTimer == TimeSpan.Zero)
                {
                    _dispatcherTimerSecondTimer.Stop();
                    MessageBox.Show("Timer Down");
                }
                // Add combobox updates here
                SelectedHourSecondTimer = (short)_timeSpanSecondTimer.Hours;
                SelectedMinuteSecondTimer = (short)_timeSpanSecondTimer.Minutes;
                SelectedSecondSecondTimer = (short)_timeSpanSecondTimer.Seconds;

                // Substracts 1 second from timer
                _timeSpanSecondTimer = _timeSpanSecondTimer.Add(TimeSpan.FromSeconds(-1));
            },
              App.Current.Dispatcher);
            _dispatcherTimerSecondTimer.Start();
        }

        /// <summary>
        /// Pauses the second timer
        /// </summary>
        private void PauseSecondTimer()
        {
            _dispatcherTimerSecondTimer.Stop();
        }

        /// <summary>
        /// Stops the second timer
        /// </summary>
        private void StopSecondTimer()
        {
            // Stopping the dispatcher timer
            _dispatcherTimerSecondTimer.Stop();

            // Resets the timer
            _timeSpanSecondTimer = TimeSpan.Zero;
            SelectedHourSecondTimer = 0;
            SelectedMinuteSecondTimer = 0;
            SelectedSecondSecondTimer = 0;
        }

        #endregion Methods to control SecondTimer

        #region Methods to control ThirdTimer

        /// <summary>
        /// Starting the timer, counting down in seconds
        /// </summary>
        private void StartThirdTimer()
        {
            /// Adding Hours, Minutes and Seconds as totalSeconds
            int _totalSecondsThirdTimer = ((int)SelectedHourThirdTimer * 3600) + ((int)SelectedMinuteThirdTimer * 60) + (int)SelectedSecondThirdTimer;

            _timeSpanThirdTimer = TimeSpan.FromSeconds(_totalSecondsThirdTimer);

            // Creating a dispatcher timer which stops when zero, counting down in seconds intervals
            _dispatcherTimerThirdTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                // If dispatcher timer equals zero > stop timer
                if (_timeSpanThirdTimer == TimeSpan.Zero)
                {
                    _dispatcherTimerThirdTimer.Stop();
                    MessageBox.Show("Timer Down");
                }
                // Add combobox updates here
                SelectedHourThirdTimer = (short)_timeSpanThirdTimer.Hours;
                SelectedMinuteThirdTimer = (short)_timeSpanThirdTimer.Minutes;
                SelectedSecondThirdTimer = (short)_timeSpanThirdTimer.Seconds;

                // Substracts 1 second from timer
                _timeSpanThirdTimer = _timeSpanThirdTimer.Add(TimeSpan.FromSeconds(-1));
            },
              App.Current.Dispatcher);
            _dispatcherTimerThirdTimer.Start();
        }

        /// <summary>
        /// Pauses the third timer
        /// </summary>
        private void PauseThirdTimer()
        {
            _dispatcherTimerThirdTimer.Stop();
        }

        /// <summary>
        /// Stops the third timer
        /// </summary>
        private void StopThirdTimer()
        {
            // Stopping the dispatcher timer
            _dispatcherTimerThirdTimer.Stop();

            // Resets the timer
            _timeSpanThirdTimer = TimeSpan.Zero;
            SelectedHourThirdTimer = 0;
            SelectedMinuteThirdTimer = 0;
            SelectedSecondThirdTimer = 0;
        }

        #endregion Methods to control ThirdTimer
    }
}