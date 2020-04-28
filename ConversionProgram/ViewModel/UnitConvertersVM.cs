using ConversionProgram.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ConversionProgram.ViewModel
{
    public class UnitConvertersVM : ViewModelBase
    {
        private Window mWindow;

        #region Members and list for distance converter

        private double _distanceUnit1;
        private double _distanceUnit2;
        private double temporaryDistanceUnit = 1;
        private Unit _selectedDistanceUnit1;
        private Unit _selectedDistanceUnit2;
        public ObservableCollection<Unit> DistanceUnitList { get; set; }

        #endregion Members and list for distance converter

        #region #region Members and list for temperature converter

        private double _temperatureUnit1;
        private double _temperatureUnit2;
        private double temporaryTemperatureUnit = 1;
        private Unit _selectedTemperatureUnit1;
        private Unit _selectedTemperatureUnit2;
        public ObservableCollection<Unit> TemperatureUnitList { get; set; }

        #endregion #region Members and list for temperature converter

        #region Members and list for velocity converter

        private double _velocityUnit1;
        private double _velocityUnit2;
        private double temporaryVelocityUnit = 1;
        private Unit _selectedvelocityUnit1;
        private Unit _selectedvelocityUnit2;
        public ObservableCollection<Unit> VelocityUnitList { get; set; }

        #endregion Members and list for velocity converter

        #region Members and list for frequency converter

        private double _frequencyUnit1;
        private double _frequencyUnit2;
        private double temporaryFrequencyUnit = 1;
        private Unit _selectedFrequencyUnit1;
        private Unit _selectedFrequencyUnit2;
        public ObservableCollection<Unit> FrequencyUnitList { get; set; }

        #endregion Members and list for frequency converter

        #region Members and list for mass converter

        private double _massUnit1;
        private double _massUnit2;
        private double temporaryMassUnit = 1;
        private Unit _selectedMassUnit1;
        private Unit _selectedMassUnit2;
        public ObservableCollection<Unit> MassUnitList { get; set; }

        #endregion Members and list for mass converter

        #region Members and list for area converter

        private double _areaUnit1;
        private double _areaUnit2;
        private double temporaryAreaUnit = 1;
        private Unit _selectedAreaUnit1;
        private Unit _selectedAreaUnit2;
        public ObservableCollection<Unit> AreaUnitList { get; set; }

        #endregion Members and list for area converter

        #region Members and list for time converter

        private double _timeUnit1;
        private double _timeUnit2;
        private double temporaryTimeUnit = 1;
        private Unit _selectedTimeUnit1;
        private Unit _selectedTimeUnit2;
        public ObservableCollection<Unit> TimeUnitList { get; set; }

        #endregion Members and list for time converter

        #region Commands

        public ICommand SwapDistanceUnitCommand { get; set; }
        public ICommand SwapTemperatureUnitCommand { get; set; }
        public ICommand SwapVelocityUnitCommand { get; set; }
        public ICommand SwapFrequencyUnitCommand { get; set; }
        public ICommand SwapMassUnitCommand { get; set; }
        public ICommand SwapAreaUnitCommand { get; set; }
        public ICommand SwapTimeUnitCommand { get; set; }

        #endregion Commands

        #region Properties for distance units

        public double DistanceUnit1
        {
            get { return _distanceUnit1; }
            set
            {
                Set(ref _distanceUnit1, value);

                // Checks if DistanceUnit1 & DistanceUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedDistanceUnit1 != null && SelectedDistanceUnit2 != null && DistanceUnit1 != temporaryDistanceUnit)
                {
                    DistanceConversion();
                }
            }
        }

        public double DistanceUnit2
        {
            get { return _distanceUnit2; }
            set
            {
                Set(ref _distanceUnit2, value);

                // Checks if DistanceUnit1 & DistanceUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedDistanceUnit1 != null && SelectedDistanceUnit2 != null && DistanceUnit1 != temporaryDistanceUnit)
                {
                    DistanceConversion();
                }
            }
        }

        public Unit SelectedDistanceUnit1
        {
            get { return _selectedDistanceUnit1; }
            set
            {
                Set(ref _selectedDistanceUnit1, value);

                // Checks if DistanceUnit1 & DistanceUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedDistanceUnit1 != null && SelectedDistanceUnit2 != null)
                {
                    DistanceConversion();
                }
            }
        }

        public Unit SelectedDistanceUnit2
        {
            get { return _selectedDistanceUnit2; }
            set
            {
                Set(ref _selectedDistanceUnit2, value);

                // Checks if DistanceUnit1 & DistanceUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedDistanceUnit1 != null && SelectedDistanceUnit2 != null)
                {
                    DistanceConversion();
                }
            }
        }

        #endregion Properties for distance units

        #region Properties for temperatures

        public double TemperatureUnit1
        {
            get { return _temperatureUnit1; }
            set
            {
                Set(ref _temperatureUnit1, value);

                // Checks if TemperatureUnit1 & TemperatureUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedTemperatureUnit1 != null && SelectedTemperatureUnit2 != null && TemperatureUnit1 != temporaryTemperatureUnit)
                {
                    TemperatureConversion();
                }
            }
        }

        public double TemperatureUnit2
        {
            get { return _temperatureUnit2; }
            set
            {
                Set(ref _temperatureUnit2, value);

                // Checks if TemperatureUnit1 & TemperatureUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedTemperatureUnit1 != null && SelectedTemperatureUnit2 != null && TemperatureUnit1 != temporaryTemperatureUnit)
                {
                    TemperatureConversion();
                }
            }
        }

        public Unit SelectedTemperatureUnit1
        {
            get { return _selectedTemperatureUnit1; }
            set
            {
                Set(ref _selectedTemperatureUnit1, value);

                // Checks if TemperatureUnit1 & TemperatureUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedTemperatureUnit1 != null && SelectedTemperatureUnit2 != null)
                {
                    TemperatureConversion();
                }
            }
        }

        public Unit SelectedTemperatureUnit2
        {
            get { return _selectedTemperatureUnit2; }
            set
            {
                Set(ref _selectedTemperatureUnit2, value);

                // Checks if TemperatureUnit1 & TemperatureUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedTemperatureUnit1 != null && SelectedTemperatureUnit2 != null)
                {
                    TemperatureConversion();
                }
            }
        }

        #endregion Properties for temperatures

        #region Properties for velocity units

        public double VelocityUnit1
        {
            get { return _velocityUnit1; }
            set
            {
                Set(ref _velocityUnit1, value);

                // Checks if velocityUnit1 & velocityUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedVelocityUnit1 != null && SelectedVelocityUnit2 != null && VelocityUnit1 != temporaryVelocityUnit)
                {
                    VelocityConversion();
                }
            }
        }

        public double VelocityUnit2
        {
            get { return _velocityUnit2; }
            set
            {
                Set(ref _velocityUnit2, value);

                // Checks if velocityUnit1 & velocityUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedVelocityUnit1 != null && SelectedVelocityUnit2 != null && VelocityUnit1 != temporaryVelocityUnit)
                {
                    VelocityConversion();
                }
            }
        }

        public Unit SelectedVelocityUnit1
        {
            get { return _selectedvelocityUnit1; }
            set
            {
                Set(ref _selectedvelocityUnit1, value);

                // Checks if velocityUnit1 & velocityUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedVelocityUnit1 != null && SelectedVelocityUnit2 != null)
                {
                    VelocityConversion();
                }
            }
        }

        public Unit SelectedVelocityUnit2
        {
            get { return _selectedvelocityUnit2; }
            set
            {
                Set(ref _selectedvelocityUnit2, value);

                // Checks if velocityUnit1 & velocityUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedVelocityUnit1 != null && SelectedVelocityUnit2 != null)
                {
                    VelocityConversion();
                }
            }
        }

        #endregion Properties for velocity units

        #region Properties for frequency units

        public double FrequencyUnit1
        {
            get { return _frequencyUnit1; }
            set
            {
                Set(ref _frequencyUnit1, value);

                // Checks if FrequencyUnit1 & FrequencyUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedFrequencyUnit1 != null && SelectedFrequencyUnit2 != null && FrequencyUnit1 != temporaryFrequencyUnit)
                {
                    FrequencyConversion();
                }
            }
        }

        public double FrequencyUnit2
        {
            get { return _frequencyUnit2; }
            set
            {
                Set(ref _frequencyUnit2, value);

                // Checks if FrequencyUnit1 & FrequencyUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedFrequencyUnit1 != null && SelectedFrequencyUnit2 != null && FrequencyUnit1 != temporaryFrequencyUnit)
                {
                    FrequencyConversion();
                }
            }
        }

        public Unit SelectedFrequencyUnit1
        {
            get { return _selectedFrequencyUnit1; }
            set
            {
                Set(ref _selectedFrequencyUnit1, value);

                // Checks if FrequencyUnit1 & FrequencyUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedFrequencyUnit1 != null && SelectedFrequencyUnit2 != null)
                {
                    FrequencyConversion();
                }
            }
        }

        public Unit SelectedFrequencyUnit2
        {
            get { return _selectedFrequencyUnit2; }
            set
            {
                Set(ref _selectedFrequencyUnit2, value);

                // Checks if FrequencyUnit1 & FrequencyUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedFrequencyUnit1 != null && SelectedFrequencyUnit2 != null)
                {
                    FrequencyConversion();
                }
            }
        }

        #endregion Properties for frequency units

        #region Properties for mass units

        public double MassUnit1
        {
            get { return _massUnit1; }
            set
            {
                Set(ref _massUnit1, value);

                // Checks if MassUnit1 & MassUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedMassUnit1 != null && SelectedMassUnit2 != null && MassUnit1 != temporaryMassUnit)
                {
                    MassConversion();
                }
            }
        }

        public double MassUnit2
        {
            get { return _massUnit2; }
            set
            {
                Set(ref _massUnit2, value);

                // Checks if MassUnit1 & MassUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedMassUnit1 != null && SelectedMassUnit2 != null && MassUnit1 != temporaryMassUnit)
                {
                    MassConversion();
                }
            }
        }

        public Unit SelectedMassUnit1
        {
            get { return _selectedMassUnit1; }
            set
            {
                Set(ref _selectedMassUnit1, value);

                // Checks if MassUnit1 & MassUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedMassUnit1 != null && SelectedMassUnit2 != null)
                {
                    MassConversion();
                }
            }
        }

        public Unit SelectedMassUnit2
        {
            get { return _selectedMassUnit2; }
            set
            {
                Set(ref _selectedMassUnit2, value);

                // Checks if MassUnit1 & MassUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedMassUnit1 != null && SelectedMassUnit2 != null)
                {
                    MassConversion();
                }
            }
        }

        #endregion Properties for mass units

        #region Properties for area units

        public double AreaUnit1
        {
            get { return _areaUnit1; }
            set
            {
                Set(ref _areaUnit1, value);

                // Checks if AreaUnit1 & AreaUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedAreaUnit1 != null && SelectedAreaUnit2 != null && AreaUnit1 != temporaryAreaUnit)
                {
                    AreaConversion();
                }
            }
        }

        public double AreaUnit2
        {
            get { return _areaUnit2; }
            set
            {
                Set(ref _areaUnit2, value);

                // Checks if AreaUnit1 & AreaUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedAreaUnit1 != null && SelectedAreaUnit2 != null && AreaUnit1 != temporaryAreaUnit)
                {
                    AreaConversion();
                }
            }
        }

        public Unit SelectedAreaUnit1
        {
            get { return _selectedAreaUnit1; }
            set
            {
                Set(ref _selectedAreaUnit1, value);

                // Checks if AreaUnit1 & AreaUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedAreaUnit1 != null && SelectedAreaUnit2 != null)
                {
                    AreaConversion();
                }
            }
        }

        public Unit SelectedAreaUnit2
        {
            get { return _selectedAreaUnit2; }
            set
            {
                Set(ref _selectedAreaUnit2, value);

                // Checks if AreaUnit1 & AreaUnit2 isn't empty and if there are units to convert from and to convert to are selected
                if (SelectedAreaUnit1 != null && SelectedAreaUnit2 != null)
                {
                    AreaConversion();
                }
            }
        }

        #endregion Properties for area units

        #region Properties for time units

        public double TimeUnit1
        {
            get { return _timeUnit1; }
            set
            {
                Set(ref _timeUnit1, value);

                if (SelectedTimeUnit1 != null && SelectedTimeUnit2 != null && TimeUnit1 != temporaryTimeUnit)
                {
                    TimeConversion();
                }
            }
        }

        public double TimeUnit2
        {
            get { return _timeUnit2; }
            set
            {
                Set(ref _timeUnit2, value);

                if (SelectedTimeUnit1 != null && SelectedTimeUnit2 != null && TimeUnit1 != temporaryTimeUnit)
                {
                    TimeConversion();
                }
            }
        }

        public Unit SelectedTimeUnit1
        {
            get { return _selectedTimeUnit1; }
            set
            {
                Set(ref _selectedTimeUnit1, value);

                if (SelectedTimeUnit1 != null && SelectedTimeUnit2 != null)
                {
                    TimeConversion();
                }
            }
        }

        public Unit SelectedTimeUnit2
        {
            get { return _selectedTimeUnit2; }
            set
            {
                Set(ref _selectedTimeUnit2, value);

                if (SelectedTimeUnit1 != null && SelectedTimeUnit2 != null)
                {
                    TimeConversion();
                }
            }
        }

        #endregion Properties for time units

        /// <summary>
        /// Custom constructor initializing lists and commands
        /// </summary>
        public UnitConvertersVM()
        {
            //mWindow = window;

            // Initializing the list with required distance units
            DistanceUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Kilometer", UnitAcronym = "km", UnitId = 10, UnitNameAndAcronym = "km - Kilometer"},
                new Unit(){UnitName = "Meter", UnitAcronym = "m", UnitId = 11, UnitNameAndAcronym = "m - Meter"},
                new Unit(){UnitName = "Centimeter", UnitAcronym = "cm", UnitId = 12, UnitNameAndAcronym = "cm - Centimeter"},
                new Unit(){UnitName = "Milimeter", UnitAcronym = "mm", UnitId = 13, UnitNameAndAcronym = "mm - Milimeter"},
                new Unit(){UnitName = "Micrometer", UnitAcronym = "µm", UnitId = 14, UnitNameAndAcronym = "μm - Micrometer"},
                new Unit(){UnitName = "Nanometer", UnitAcronym = "nm", UnitId = 15, UnitNameAndAcronym = "nm - Nanometer"},

                new Unit(){UnitName = "Mile", UnitAcronym = "mi", UnitId = 16, UnitNameAndAcronym = "mi - Mile"},
                new Unit(){UnitName = "Yard", UnitAcronym = "yd", UnitId = 17, UnitNameAndAcronym = "yd - Yard"},
                new Unit(){UnitName = "Foot", UnitAcronym = "ft", UnitId = 18, UnitNameAndAcronym = "ft - Foot"},
                new Unit(){UnitName = "Inch", UnitAcronym = "in", UnitId = 19, UnitNameAndAcronym = "in - Inch"}

                // Add Nautical Mile, Blue Whales
            };

            // Initializing the list with required temperature units
            TemperatureUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Celcius", UnitAcronym = "C", UnitId = 1, UnitNameAndAcronym = "°C - Celcius"},
                new Unit(){UnitName = "Kelvin", UnitAcronym = "K", UnitId = 2, UnitNameAndAcronym = "°K - Kelvin"},
                new Unit(){UnitName = "Fahrenheit", UnitAcronym = "F", UnitId = 3, UnitNameAndAcronym = "°F - Fahrenheit"}
            };

            // Initializing the list with required velocity units
            VelocityUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Kilometer per hour", UnitAcronym = "kp/h", UnitId = 31, UnitNameAndAcronym = "kp/h - Kilometer per hour"},
                new Unit(){UnitName = "Meter per second", UnitAcronym = "m/s", UnitId = 32, UnitNameAndAcronym = "m/s - Meter per second"},

                new Unit(){UnitName = "Mile per hour", UnitAcronym = "mi/h", UnitId = 33, UnitNameAndAcronym = "mi/h - Mile per hour"},
                new Unit(){UnitName = "Foot per second", UnitAcronym = "ft/s", UnitId = 34, UnitNameAndAcronym = "ft/s - Foot per second"},

                new Unit(){UnitName = "Knots", UnitAcronym = "knots", UnitId = 35, UnitNameAndAcronym = "Knots"},

                new Unit(){UnitName = "Lightspeed", UnitAcronym = "ls", UnitId = 36, UnitNameAndAcronym = "c - Lightspeed"},
            };

            // Initializing the list with required frequency units
            FrequencyUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Hertz", UnitAcronym = "Hz", UnitId = 40, UnitNameAndAcronym = "Hz - Hertz"},
                new Unit(){UnitName = "Kilohertz", UnitAcronym = "KHz", UnitId = 41, UnitNameAndAcronym = "KHz - Kilohertz"},
                new Unit(){UnitName = "Megahertz", UnitAcronym = "MHz", UnitId = 42, UnitNameAndAcronym = "MHz - Megahertz"},
                new Unit(){UnitName = "Gigahertz", UnitAcronym = "GHz", UnitId = 43, UnitNameAndAcronym = "GHz - Gigahertz"}
            };

            // Initializing the list with required mass units
            MassUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Tonne", UnitAcronym = "t", UnitId = 50, UnitNameAndAcronym = "t - Tonne"},
                new Unit(){UnitName = "Kilogram", UnitAcronym = "kg", UnitId = 51, UnitNameAndAcronym = "kg - Kilogram"},
                new Unit(){UnitName = "Gram", UnitAcronym = "g", UnitId = 52, UnitNameAndAcronym = "g - Gram"},
                new Unit(){UnitName = "Milligram", UnitAcronym = "mg", UnitId = 53, UnitNameAndAcronym = "mg - Milligram"},
                new Unit(){UnitName = "Microgram", UnitAcronym = "mcg", UnitId = 54, UnitNameAndAcronym = "mcg - Microgram"},

                new Unit(){UnitName = "Imperial Ton", UnitAcronym = "long ton", UnitId = 55, UnitNameAndAcronym = "long ton - Imperial Ton"},
                new Unit(){UnitName = "US Ton", UnitAcronym = "short ton", UnitId = 56, UnitNameAndAcronym = "short ton - US Ton"},

                new Unit(){UnitName = "Stone", UnitAcronym = "st", UnitId = 57, UnitNameAndAcronym = "st - Stone"},
                new Unit(){UnitName = "Pound", UnitAcronym = "lb", UnitId = 58, UnitNameAndAcronym = "lb - Pound"},
                new Unit(){UnitName = "Ounce", UnitAcronym = "oz", UnitId = 59, UnitNameAndAcronym = "oz - Ounce"}
            };

            // Initializing the list with required area units
            AreaUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Square kilometer", UnitAcronym = "km²", UnitId = 60, UnitNameAndAcronym = "km² - Square kilometer"},
                new Unit(){UnitName = "Hectare", UnitAcronym = "ha", UnitId = 61, UnitNameAndAcronym = "ha - Hectare"},
                new Unit(){UnitName = "Square meter", UnitAcronym = "m²", UnitId = 62, UnitNameAndAcronym = "m² - Square meter"},
                new Unit(){UnitName = "Square centimeter", UnitAcronym = "cm²", UnitId = 63, UnitNameAndAcronym = "cm² - Square centimeter"},
                new Unit(){UnitName = "Square mile", UnitAcronym = "mi²", UnitId = 64, UnitNameAndAcronym = "mi² - Square mile"},
                new Unit(){UnitName = "Acre", UnitAcronym = "ac", UnitId = 65, UnitNameAndAcronym = "ac - Acre"},
                new Unit(){UnitName = "Square yard", UnitAcronym = "yd²", UnitId = 66, UnitNameAndAcronym = "yd² - Square yard"},
                new Unit(){UnitName = "Square foot", UnitAcronym = "ft²", UnitId = 67, UnitNameAndAcronym = "ft² - Square foot"},
                new Unit(){UnitName = "Square inch", UnitAcronym = "in²", UnitId = 68, UnitNameAndAcronym = "in² - Square inch"}
            };

            // Initializing the lust with required time units
            TimeUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Year", UnitAcronym = "YYYY", UnitId= 70, UnitNameAndAcronym = "YYYY - Year"},
                new Unit(){UnitName = "Month", UnitAcronym = "MM", UnitId= 71, UnitNameAndAcronym = "MM - Month"},
                new Unit(){UnitName = "Week", UnitAcronym = "W", UnitId= 72, UnitNameAndAcronym = "W - Week"},
                new Unit(){UnitName = "Day", UnitAcronym = "DD", UnitId= 73, UnitNameAndAcronym = "DD - Day"},
                new Unit(){UnitName = "Hour", UnitAcronym = "h", UnitId= 74, UnitNameAndAcronym = "h - Hour"},
                new Unit(){UnitName = "Minute", UnitAcronym = "m", UnitId= 75, UnitNameAndAcronym = "m - Minute"},
                new Unit(){UnitName = "Second", UnitAcronym = "s", UnitId= 76, UnitNameAndAcronym = "s - Second"},
                new Unit(){UnitName = "Millisecond", UnitAcronym = "ms", UnitId= 77, UnitNameAndAcronym = "ms - Millisecond"}
            };

            // Relay commands
            SwapDistanceUnitCommand = new RelayCommand(() => SwapDistancesButtonClick("SwapDistanceUnitButton"));
            SwapTemperatureUnitCommand = new RelayCommand(() => SwapTemperaturesButtonClick("SwapTemperatureUnitButton"));
            SwapVelocityUnitCommand = new RelayCommand(() => SwapVelocityButtonClick("SwapVelocityUnitButton"));
            SwapFrequencyUnitCommand = new RelayCommand(() => SwapFrequencyButtonClick("SwapFrequencyUnitButton"));
            SwapMassUnitCommand = new RelayCommand(() => SwapMassButtonClick("SwapMassUnitButton"));
            SwapAreaUnitCommand = new RelayCommand(() => SwapAreaButtonClick("SwapAreaUnitButton"));
            SwapTimeUnitCommand = new RelayCommand(() => SwapTimeButtonClick("SwapTimeUnitButton"));
        }

        #region conversion logic for distances

        /// <summary>
        /// Swapping SelectedDistanceUnit1 and SelectedDistanceUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapDistancesButtonClick(object sender)
        {
            Unit temporaryDistanceUnit;

            temporaryDistanceUnit = SelectedDistanceUnit1;
            SelectedDistanceUnit1 = SelectedDistanceUnit2;
            SelectedDistanceUnit2 = temporaryDistanceUnit;
        }

        /// <summary>
        /// Conversion logic for distances
        /// </summary>
        public void DistanceConversion()
        {
            // Temporary storage to avoid loops
            temporaryDistanceUnit = DistanceUnit1;

            #region Conversion from Kilometer to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units

            // Handeling conversion from Kilometer to Kilometer
            if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Kilometer to Kilometer = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Kilometer to meter = Kilometer * 1000
                DistanceUnit2 = DistanceUnit1 * 1000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Decimeter")
            {
                // Formula to convert Kilometer to Decimeter = Kilometer * 10000
                DistanceUnit2 = DistanceUnit1 * 10000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Kilometer to Centimeter = Kilometer * 100000
                DistanceUnit2 = DistanceUnit1 * 100000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Kilometer to Milimeter = Kilometer * 1000000
                DistanceUnit2 = DistanceUnit1 * 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Kilometer to Micrometer = Kilometer * 10000
                DistanceUnit2 = DistanceUnit1 * 1000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Kilometer to Nanometer = Kilometer * 10000
                DistanceUnit2 = DistanceUnit1 * 1000000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Kilometer to Mile = Kilometer * 0.62137
                DistanceUnit2 = DistanceUnit1 * 0.62137;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Kilometer to Yard = Kilometer * 1094
                DistanceUnit2 = DistanceUnit1 * 1094;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Kilometer to Foot = Kilometer * 3280.84
                DistanceUnit2 = DistanceUnit1 * 3280.84;
            }
            else if (SelectedDistanceUnit1.UnitName == "Kilometer" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Kilometer to Inch = Kilometer * 39370.07874
                DistanceUnit2 = DistanceUnit1 * 39370.07874;
            }

            #endregion Conversion from Kilometer to any

            #region Conversion from Meter to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Meter to Meter = Meter / 1000
                DistanceUnit2 = DistanceUnit1 / 1000;
            }
            // Handeling conversion from Meter to Meter
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Meter to Meter = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Meter to Centimeter = Meter * 100000
                DistanceUnit2 = DistanceUnit1 * 100;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Meter to Milimeter = Meter * 1000
                DistanceUnit2 = DistanceUnit1 * 1000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Meter to Micrometer = Meter * 1000000
                DistanceUnit2 = DistanceUnit1 * 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Meter to Nanometer = Meter * 1000000000
                DistanceUnit2 = DistanceUnit1 * 1000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Meter to Mile = Meter * 1609
                DistanceUnit2 = DistanceUnit1 / 1609;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Meter to Yard = Meter * 1.094
                DistanceUnit2 = DistanceUnit1 * 1.094;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Meter to Foot = Meter * 3.281
                DistanceUnit2 = DistanceUnit1 * 3.281;
            }
            else if (SelectedDistanceUnit1.UnitName == "Meter" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Meter to Inch = Meter * 39.37
                DistanceUnit2 = DistanceUnit1 * 39.37;
            }

            #endregion Conversion from Meter to any

            #region Conversion from Centimeter to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Centimeter to Kilometer = Centimeter / 100000
                DistanceUnit2 = DistanceUnit1 / 100000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Centimeter to Centimeter = Centimeter / 100
                DistanceUnit2 = DistanceUnit1 / 100;
            }
            // Handeling conversion from Centimeter to Centimeter
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Centimeter to Centimeter = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Centimeter to Milimeter = Centimeter * 10
                DistanceUnit2 = DistanceUnit1 * 10;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Centimeter to Micrometer = Centimeter * 10000
                DistanceUnit2 = DistanceUnit1 * 10000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Centimeter to Nanometer = Centimeter * 10000000
                DistanceUnit2 = DistanceUnit1 * 10000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Centimeter to Mile = Centimeter / 160934
                DistanceUnit2 = DistanceUnit1 / 160934;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Centimeter to Yard = Centimeter / 91.44
                DistanceUnit2 = DistanceUnit1 / 91.44;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Centimeter to Foot = Centimeter / 30.48
                DistanceUnit2 = DistanceUnit1 / 30.48;
            }
            else if (SelectedDistanceUnit1.UnitName == "Centimeter" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Centimeter to Inch = Centimeter / 2.54
                DistanceUnit2 = DistanceUnit1 / 2.54;
            }

            #endregion Conversion from Centimeter to any

            #region Conversion from Milimeter to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Milimeter to Kilometer = Milimeter / 1000000
                DistanceUnit2 = DistanceUnit1 / 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Milimeter to Centimeter = Milimeter / 100
                DistanceUnit2 = DistanceUnit1 / 1000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Milimeter to Milimeter = Centimeter / 10
                DistanceUnit2 = DistanceUnit1 / 10;
            }
            // Handeling conversion from Milimeter to Milimeter
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Milimeter to Milimeter = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Milimeter to Micrometer = Milimeter * 10000
                DistanceUnit2 = DistanceUnit1 * 1000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Milimeter to Nanometer = Milimeter * 10000000
                DistanceUnit2 = DistanceUnit1 * 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Milimeter to Mile = Milimeter / 160934
                DistanceUnit2 = DistanceUnit1 / 1609340;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Milimeter to Yard = Milimeter / 914
                DistanceUnit2 = DistanceUnit1 / 914;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Milimeter to Foot = Milimeter / 30.48
                DistanceUnit2 = DistanceUnit1 / 305;
            }
            else if (SelectedDistanceUnit1.UnitName == "Milimeter" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Milimeter to Inch = Milimeter / 2.54
                DistanceUnit2 = DistanceUnit1 / 25.4;
            }

            #endregion Conversion from Milimeter to any

            #region Conversion from Micrometer to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Micrometer to Kilometer = Micrometer / 1000000000
                DistanceUnit2 = DistanceUnit1 / 1000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Micrometer to meter = Micrometer / 1000000
                DistanceUnit2 = DistanceUnit1 / 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Micrometer to Centimeter = Micrometer / 10000
                DistanceUnit2 = DistanceUnit1 / 10000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Micrometer to Milimeter = Micrometer * 10000
                DistanceUnit2 = DistanceUnit1 / 1000;
            }
            // Handeling conversion from Micrometer to Micrometer
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Micrometer to Milimeter = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Micrometer to Nanometer = Micrometer * 10000000
                DistanceUnit2 = DistanceUnit1 * 10000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Micrometer to Mile = Micrometer / 160934
                DistanceUnit2 = DistanceUnit1 / 1609340000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Micrometer to Yard = Micrometer / 914400
                DistanceUnit2 = DistanceUnit1 / 914400;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Micrometer to Foot = Micrometer / 30.48
                DistanceUnit2 = DistanceUnit1 / 304800;
            }
            else if (SelectedDistanceUnit1.UnitName == "Micrometer" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Micrometer to Inch = Micrometer / 2.54
                DistanceUnit2 = DistanceUnit1 / 25400;
            }

            #endregion Conversion from Micrometer to any

            #region Conversion from Nanometer to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Nanometer to Kilometer = Nanometer / 1000000000000
                DistanceUnit2 = DistanceUnit1 / 1000000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Nanometer to meter = Nanometer / 1000000000
                DistanceUnit2 = DistanceUnit1 / 1000000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Nanometer to Centimeter = Nanometer / 10000000
                DistanceUnit2 = DistanceUnit1 / 10000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Nanometer to Milimeter = Nanometer /  1000000
                DistanceUnit2 = DistanceUnit1 / 1000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Nanometer to Micrometer = Nanometer / 10000
                DistanceUnit2 = DistanceUnit1 / 10000;
            }
            // Handeling conversion from Nanometer to Nanometer
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Nanometer to Nanometer = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Nanometer to Mile = Nanometer / 1609340000000
                DistanceUnit2 = DistanceUnit1 / 1609340000000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Nanometer to Mile = Nanometer / 914400000
                DistanceUnit2 = DistanceUnit1 / 914400000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Nanometer to Foot = Nanometer / 304800000
                DistanceUnit2 = DistanceUnit1 / 304800000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Nanometer" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Nanometer to Inch = Nanometer / 25400000
                DistanceUnit2 = DistanceUnit1 / 25400000;
            }

            #endregion Conversion from Nanometer to any

            #region Conversion from Mile to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Mile to Kilometer = Mile * 1.60934
                DistanceUnit2 = DistanceUnit1 * 1.60934;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Mile to meter = Mile * 1609.344
                DistanceUnit2 = DistanceUnit1 * 1609.344;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Mile to Centimeter = Mile * 160934.4
                DistanceUnit2 = DistanceUnit1 * 160934.4;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Mile to Milimeter = Mile * 1609344
                DistanceUnit2 = DistanceUnit1 * 1609344;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Mile to Micrometer = Mile * 1609344000
                DistanceUnit2 = DistanceUnit1 * 1609344000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Mile to Nanometer = Mile * 1609344000000
                DistanceUnit2 = DistanceUnit1 * 1609344000000;
            }
            // Handeling conversion from Mile to Mile
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Mile to Mile = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Mile to Yard = Mile * 1760
                DistanceUnit2 = DistanceUnit1 * 1760;
            }
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Mile to Foot = Mile * 1609344000000
                DistanceUnit2 = DistanceUnit1 * 5280;
            }
            // Handeling conversion from Mile to Mile
            else if (SelectedDistanceUnit1.UnitName == "Mile" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Mile to Inch = Mile * 63360
                DistanceUnit2 = DistanceUnit1 * 63360;
            }

            #endregion Conversion from Mile to any

            #region Conversion from Yard to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Yard to Kilometer = Yard / 1094
                DistanceUnit2 = DistanceUnit1 / 1094;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Yard to meter = Yard / 1094
                DistanceUnit2 = DistanceUnit1 / 1094;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Yard to Centimeter = Yard * 91.44
                DistanceUnit2 = DistanceUnit1 * 91.44;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Yard to Milimeter = Yard * 914
                DistanceUnit2 = DistanceUnit1 * 914;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Yard to Micrometer = Yard * 914400
                DistanceUnit2 = DistanceUnit1 * 914400;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Yard to Nanometer = Yard * 914400000
                DistanceUnit2 = DistanceUnit1 * 914400000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Yard to Mile = Yard / 1760
                DistanceUnit2 = DistanceUnit1 / 1760;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Yard to Yard = 1 = 1
                DistanceUnit2 = DistanceUnit1;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Yard to Foot = Yard * 3
                DistanceUnit2 = DistanceUnit1 * 3;
            }
            else if (SelectedDistanceUnit1.UnitName == "Yard" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Yard to Inch = Yard * 36
                DistanceUnit2 = DistanceUnit1 * 36;
            }

            #endregion Conversion from Yard to any

            #region Conversion from Foot to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Foot to Kilometer = Foot / 3281
                DistanceUnit2 = DistanceUnit1 / 3281;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Foot to meter = Foot / 3.281
                DistanceUnit2 = DistanceUnit1 / 3.281;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Foot to Centimeter = Foot * 30.48
                DistanceUnit2 = DistanceUnit1 * 30.48;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Foot to Milimeter = Foot * 304.8
                DistanceUnit2 = DistanceUnit1 * 304.8;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Foot to Micrometer = Foot * 304800
                DistanceUnit2 = DistanceUnit1 * 304800;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Foot to Nanometer = Foot * 304800000
                DistanceUnit2 = DistanceUnit1 * 304800000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Foot to Mile = Foot * 5280
                DistanceUnit2 = DistanceUnit1 * 5280;
            }
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Foot to Yard = Foot * 3
                DistanceUnit2 = DistanceUnit1 * 3;
            }
            // Handeling conversion from Foot to Foot
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Foot to Foot = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }
            // Handeling conversion from Foot to Inch
            else if (SelectedDistanceUnit1.UnitName == "Foot" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Foot to Inch = Foot * 12
                DistanceUnit2 = DistanceUnit1 * 12;
            }

            #endregion Conversion from Foot to any

            #region Conversion from Inch to any

            // Conversion starts when SelectedDistanceUnit1 and SelectedDistanceUnit2 are initialized with distance units
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Kilometer")
            {
                // Formula to convert Inch to Kilometer = Inch / 39370
                DistanceUnit2 = DistanceUnit1 / 39370;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Meter")
            {
                // Formula to convert Inch to meter = Inch / 39.37
                DistanceUnit2 = DistanceUnit1 / 39.37;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Centimeter")
            {
                // Formula to convert Inch to Centimeter = Inch * 2.54
                DistanceUnit2 = DistanceUnit1 * 2.54;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Milimeter")
            {
                // Formula to convert Inch to Milimeter = Inch * 25.4
                DistanceUnit2 = DistanceUnit1 * 25.4;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Micrometer")
            {
                // Formula to convert Inch to Micrometer = Inch * 25400
                DistanceUnit2 = DistanceUnit1 * 25400;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Nanometer")
            {
                // Formula to convert Inch to Nanometer = Inch * 25400000
                DistanceUnit2 = DistanceUnit1 * 25400000;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Mile")
            {
                // Formula to convert Inch to Foot = Inch * 63360
                DistanceUnit2 = DistanceUnit1 * 63360;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Yard")
            {
                // Formula to convert Inch to Yard = Inch * 36
                DistanceUnit2 = DistanceUnit1 * 36;
            }
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Foot")
            {
                // Formula to convert Inch to Inch = Inch / 12
                DistanceUnit2 = DistanceUnit1 / 12;
            }
            // Handeling conversion from Inch to Inch
            else if (SelectedDistanceUnit1.UnitName == "Inch" && SelectedDistanceUnit2.UnitName == "Inch")
            {
                // Formula to convert Inch to Inch = 1 to 1
                DistanceUnit2 = DistanceUnit1;
            }

            #endregion Conversion from Inch to any
        }

        #endregion conversion logic for distances

        #region conversion logic for temperatures

        /// <summary>
        /// Swapping SelectedTemperateUnit1 and SelectedTemperatureUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapTemperaturesButtonClick(object sender)
        {
            Unit temporaryTemperatureUnit;

            temporaryTemperatureUnit = SelectedTemperatureUnit1;
            SelectedTemperatureUnit1 = SelectedTemperatureUnit2;
            SelectedTemperatureUnit2 = temporaryTemperatureUnit;
        }

        /// <summary>
        /// Conversion logic for temperatures
        /// </summary>
        public void TemperatureConversion()
        {
            // Temporary storage to avoid loops
            temporaryTemperatureUnit = TemperatureUnit1;

            #region Celcius Conversion

            // Conversion starts when SelectedTemperatureUnit1 and SelectedTemperatureUnit2 are initialized with temperature units
            if (SelectedTemperatureUnit1.UnitName == "Celcius" && SelectedTemperatureUnit2.UnitName == "Kelvin")
            {
                // Formula to convert Celcius to Kelvin = Celcius + 273.15
                TemperatureUnit2 = TemperatureUnit1 + 273.15;
            }
            else if (SelectedTemperatureUnit1.UnitName == "Celcius" && SelectedTemperatureUnit2.UnitName == "Fahrenheit")
            {
                // Formula to convert Celcius to Fahrenheit = (Celcius * 9) / 5) + 32
                TemperatureUnit2 = ((TemperatureUnit1 * 9) / 5) + 32;
            }
            // Handeling conversion from Celcius to Celcius
            else if (SelectedTemperatureUnit1.UnitName == "Celcius" && SelectedTemperatureUnit2.UnitName == "Celcius")
            {
                // Formula to convert Celcius to Celcius = 1 to 1
                TemperatureUnit2 = TemperatureUnit1;
            }

            #endregion Celcius Conversion

            #region Kelvin Conversion

            // Conversion starts when SelectedTemperatureUnit1 and SelectedTemperatureUnit2 are initialized with temperature units
            else if (SelectedTemperatureUnit1.UnitName == "Kelvin" && SelectedTemperatureUnit2.UnitName == "Celcius")
            {
                // Formula to convert Kelvin to Celcius = Kelvin - 273,15
                TemperatureUnit2 = TemperatureUnit1 - 273.15;
            }
            else if (SelectedTemperatureUnit1.UnitName == "Kelvin" && SelectedTemperatureUnit2.UnitName == "Fahrenheit")
            {
                // Formula to convert Kelvin to Fahrenheit = (Kelvin - 273.15) * 9/5 + 32
                TemperatureUnit2 = (TemperatureUnit1 - 273.15) * 9 / 5 + 32;
            }
            // Handeling conversion from Kelvin to Kelvin
            else if (SelectedTemperatureUnit1.UnitName == "Kelvin" && SelectedTemperatureUnit2.UnitName == "Kelvin")
            {
                // Formula to convert Kelvin to Kelvin = 1 to 1
                TemperatureUnit2 = TemperatureUnit1;
            }

            #endregion Kelvin Conversion

            #region Fahrenheit Conversion

            // Conversion starts when SelectedTemperatureUnit1 and SelectedTemperatureUnit2 are initialized with temperature units
            else if (SelectedTemperatureUnit1.UnitName == "Fahrenheit" && SelectedTemperatureUnit2.UnitName == "Celcius")
            {
                // Formula to convert Fahrenheit to Celcius = (Fahrenheit - 32) * 5/9
                TemperatureUnit2 = (TemperatureUnit1 - 32) * 5 / 9;
            }
            else if (SelectedTemperatureUnit1.UnitName == "Fahrenheit" && SelectedTemperatureUnit2.UnitName == "Kelvin")
            {
                // Formula to convert Fahrenheit to Kelvin =
                TemperatureUnit2 = (TemperatureUnit1 - 32) * 5 / 9 + 273.15;
            }
            // Handeling conversion from Fahrenheit to Fahrenheit
            else if (SelectedTemperatureUnit1.UnitName == "Fahrenheit" && SelectedTemperatureUnit2.UnitName == "Fahrenheit")
            {
                // Formula to convert Fahrenheit to Fahrenheit = 1 to 1
                TemperatureUnit2 = TemperatureUnit1;
            }

            #endregion Fahrenheit Conversion
        }

        #endregion conversion logic for temperatures

        #region conversion logic for velocity

        /// <summary>
        /// Swapping SelectedVelocityUnit1 and SelectedVelocityUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapVelocityButtonClick(object sender)
        {
            Unit temporaryvelocityUnit;

            temporaryvelocityUnit = SelectedVelocityUnit1;
            SelectedVelocityUnit1 = SelectedVelocityUnit2;
            SelectedVelocityUnit2 = temporaryvelocityUnit;
        }

        /// <summary>
        /// Conversion logic for velocity
        /// </summary>
        public void VelocityConversion()
        {
            // Temporary storage to avoid loops
            temporaryVelocityUnit = VelocityUnit1;

            #region Kilometer per hour conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Kilometer per hour to Meter per second = Kilometer per hour / 3.6
                VelocityUnit2 = VelocityUnit1 / 3.6;
            }
            else if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Kilometer per hour to Mile per hour = Kilometer per hour / 1.609
                VelocityUnit2 = VelocityUnit1 / 1.609;
            }
            else if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Kilometer per hour to Foot per second = Kilometer per hour / 1.097
                VelocityUnit2 = VelocityUnit1 / 1.097;
            }
            else if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Kilometer per hour to Knots = Kilometer per hour / 1.852
                VelocityUnit2 = VelocityUnit1 / 1.852;
            }
            else if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Kilometer per hour to Lightspeed = Kilometer per hour / 1079000000
                VelocityUnit2 = VelocityUnit1 / 1079000000;
            }
            // Handling conversion from Kilometer per hour to Kilometer per hour
            else if (SelectedVelocityUnit1.UnitName == "Kilometer per hour" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Kilometer per hour to Kilometer per hour = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Kilometer per hour conversion

            #region Meter per second conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Meter per second to Kilometer per hour = Meter per second * 3.6
                VelocityUnit2 = VelocityUnit1 * 3.6;
            }
            else if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Meter per second to Mile per hour = Meter per second * 2.237
                VelocityUnit2 = VelocityUnit1 * 2.237;
            }
            else if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Meter per second to Foot per second = Meter per second * 3.281
                VelocityUnit2 = VelocityUnit1 * 3.281;
            }
            else if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Meter per second to Knots = Meter per second * 1.944
                VelocityUnit2 = VelocityUnit1 * 1.944;
            }
            else if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Kilometer per hour to Lightspeed = Meter per second / 299800000
                VelocityUnit2 = VelocityUnit1 / 299800000;
            }
            // Handling conversion from Meter per second to Meter per second
            else if (SelectedVelocityUnit1.UnitName == "Meter per second" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Meter per second to Meter per second = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Meter per second conversion

            #region Mile per hour conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Mile per hour to Kilometer per hour = Mile per hour * 1.609
                VelocityUnit2 = VelocityUnit1 * 1.609;
            }
            else if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Mile per hour to Meter per second = Mile per hour / 2.237
                VelocityUnit2 = VelocityUnit1 / 2.237;
            }
            else if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Mile per hour to Foot per second = Mile per hour * 1.467
                VelocityUnit2 = VelocityUnit1 * 1.467;
            }
            else if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Mile per hour to Knots = Mile per hour / 1.151
                VelocityUnit2 = VelocityUnit1 / 1.151;
            }
            else if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Mile per hour to Lightspeed = Mile per hour/ 670600000
                VelocityUnit2 = VelocityUnit1 / 670600000;
            }
            // Handling conversion from Mile per hour to Mile per hour
            else if (SelectedVelocityUnit1.UnitName == "Mile per hour" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Mile per hour to Mile per hour = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Mile per hour conversion

            #region Foot per second conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Foot per second to Kilometer per hour = Foot per second * 1.097
                VelocityUnit2 = VelocityUnit1 * 1.097;
            }
            else if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Foot per second to Meter per second = Foot per second / 3.281
                VelocityUnit2 = VelocityUnit1 / 3.281;
            }
            else if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Foot per second to Mile per hour = Foot per second / 1.467
                VelocityUnit2 = VelocityUnit1 / 1.467;
            }
            else if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Foot per second to Knots = Foot per second / 1.688
                VelocityUnit2 = VelocityUnit1 / 1.688;
            }
            else if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Foot per second to Lightspeed = Foot per second / 983600000
                VelocityUnit2 = VelocityUnit1 / 983600000;
            }
            // Handling conversion from Foot per second to Foot per second
            else if (SelectedVelocityUnit1.UnitName == "Foot per second" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Foot per second to Foot per second = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Foot per second conversion

            #region Knots conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Knots to Kilometer per hour = Knots * 1.852
                VelocityUnit2 = VelocityUnit1 * 1.852;
            }
            else if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Knots to Meter per second = Knots / 1.944
                VelocityUnit2 = VelocityUnit1 / 1.944;
            }
            else if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Knots to Mile per hour = Knots * 1.151
                VelocityUnit2 = VelocityUnit1 * 1.151;
            }
            else if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Knots to Knots = Foot per second * 1.688
                VelocityUnit2 = VelocityUnit1 * 1.688;
            }
            else if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Knots to Lightspeed = Knots / 582700000
                VelocityUnit2 = VelocityUnit1 / 582700000;
            }
            // Handling conversion Knots to Knots
            else if (SelectedVelocityUnit1.UnitName == "Knots" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Knots to Knots = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Knots conversion

            #region Lightspeed conversion

            // Conversion starts when SelectedvelocityUnit1 and SelectedvelocityUnit2 are initialized with velocity units
            if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Kilometer per hour")
            {
                // Formula to convert Lightspeed to Kilometer per hour = Lightspeed * 1079000000
                VelocityUnit2 = VelocityUnit1 * 1079000000;
            }
            else if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Meter per second")
            {
                // Formula to convert Lightspeed to Meter per second = Lightspeed * 299800000
                VelocityUnit2 = VelocityUnit1 * 299800000;
            }
            else if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Mile per hour")
            {
                // Formula to convert Lightspeed to Mile per hour = Lightspeed * 670600000
                VelocityUnit2 = VelocityUnit1 * 670600000;
            }
            else if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Foot per second")
            {
                // Formula to convert Lightspeed to Knots = Foot per Lightspeed * 983600000
                VelocityUnit2 = VelocityUnit1 * 983600000;
            }
            else if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Knots")
            {
                // Formula to convert Lightspeed to Lightspeed = Lightspeed * 582700000
                VelocityUnit2 = VelocityUnit1 * 582700000;
            }
            // Handling conversion Lightspeed to Lightspeed
            else if (SelectedVelocityUnit1.UnitName == "Lightspeed" && SelectedVelocityUnit2.UnitName == "Lightspeed")
            {
                // Formula to convert Lightspeed to Lightspeed = 1 to 1
                VelocityUnit2 = VelocityUnit1;
            }

            #endregion Lightspeed conversion
        }

        #endregion conversion logic for velocity

        #region conversion logic for frequency

        /// <summary>
        /// Swapping SelectedFrequencyUnit1 and SelectedFrequencyUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapFrequencyButtonClick(object sender)
        {
            Unit temporaryFrequencyUnit;

            temporaryFrequencyUnit = SelectedFrequencyUnit1;
            SelectedFrequencyUnit1 = SelectedFrequencyUnit2;
            SelectedFrequencyUnit2 = temporaryFrequencyUnit;
        }

        public void FrequencyConversion()
        {
            // Temporary storage to avoid loops
            temporaryFrequencyUnit = FrequencyUnit1;

            #region Hertz Conversion

            // Conversion starts when SelectedFrequencyUnit1 and SelectedFrequencyUnit2 are initialized with velocity units
            if (SelectedFrequencyUnit1.UnitName == "Hertz" && SelectedFrequencyUnit2.UnitName == "Kilohertz")
            {
                // Formula to convert Hertz to Kilohertz = Hertz / 1000
                FrequencyUnit2 = FrequencyUnit1 / 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Hertz" && SelectedFrequencyUnit2.UnitName == "Megahertz")
            {
                // Formula to convert Hertz to Kilohertz = Hertz / 1000000
                FrequencyUnit2 = FrequencyUnit1 / 1000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Hertz" && SelectedFrequencyUnit2.UnitName == "Gigahertz")
            {
                // Formula to convert Hertz to Kilohertz = Hertz / 1000000000
                FrequencyUnit2 = FrequencyUnit1 / 1000000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Hertz" && SelectedFrequencyUnit2.UnitName == "Hertz")
            {
                // Formula to convert Hertz to Hertz = 1 to 1
                FrequencyUnit2 = FrequencyUnit1;
            }

            #endregion Hertz Conversion

            #region Kilohertz Conversion

            // Conversion starts when SelectedFrequencyUnit1 and SelectedFrequencyUnit2 are initialized with velocity units
            if (SelectedFrequencyUnit1.UnitName == "Kilohertz" && SelectedFrequencyUnit2.UnitName == "Hertz")
            {
                // Formula to convert Kilohertz to Hertz = Kilohertz * 1000
                FrequencyUnit2 = FrequencyUnit1 * 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Kilohertz" && SelectedFrequencyUnit2.UnitName == "Megahertz")
            {
                // Formula to convert Kilohertz to Megahertz = Kilohertz / 1000
                FrequencyUnit2 = FrequencyUnit1 / 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Kilohertz" && SelectedFrequencyUnit2.UnitName == "Gigahertz")
            {
                // Formula to convert Kilohertz to Gigahertz = Kilohertz / 1000000
                FrequencyUnit2 = FrequencyUnit1 / 1000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Kilohertz" && SelectedFrequencyUnit2.UnitName == "Kilohertz")
            {
                // Formula to convert Kilohertz to Kilohertz = 1 to 1
                FrequencyUnit2 = FrequencyUnit1;
            }

            #endregion Kilohertz Conversion

            #region Megahertz conversion

            // Conversion starts when SelectedFrequencyUnit1 and SelectedFrequencyUnit2 are initialized with velocity units
            if (SelectedFrequencyUnit1.UnitName == "Megahertz" && SelectedFrequencyUnit2.UnitName == "Hertz")
            {
                // Formula to convert Megahertz to Hertz = Megahertz * 1000000
                FrequencyUnit2 = FrequencyUnit1 * 1000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Megahertz" && SelectedFrequencyUnit2.UnitName == "Kilohertz")
            {
                // Formula to convert Megahertz to Kilohertz = Megahertz * 1000
                FrequencyUnit2 = FrequencyUnit1 * 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Megahertz" && SelectedFrequencyUnit2.UnitName == "Gigahertz")
            {
                // Formula to convert Megahertz to Gigahertz = Megahertz / 1000
                FrequencyUnit2 = FrequencyUnit1 / 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Megahertz" && SelectedFrequencyUnit2.UnitName == "Megahertz")
            {
                // Formula to convert Megahertz to Megahertz = 1 to 1
                FrequencyUnit2 = FrequencyUnit1;
            }

            #endregion Megahertz conversion

            #region Gigahertz conversion

            // Conversion starts when SelectedFrequencyUnit1 and SelectedFrequencyUnit2 are initialized with velocity units
            if (SelectedFrequencyUnit1.UnitName == "Gigahertz" && SelectedFrequencyUnit2.UnitName == "Hertz")
            {
                // Formula to convert Gigahertz to Hertz = Gigahertz * 1000000000
                FrequencyUnit2 = FrequencyUnit1 * 1000000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Gigahertz" && SelectedFrequencyUnit2.UnitName == "Kilohertz")
            {
                // Formula to convert Gigahertz to Kilohertz = Gigahertz * 1000000
                FrequencyUnit2 = FrequencyUnit1 * 1000000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Gigahertz" && SelectedFrequencyUnit2.UnitName == "Megahertz")
            {
                // Formula to convert Gigahertz to Megahertz = Gigahertz * 1000
                FrequencyUnit2 = FrequencyUnit1 * 1000;
            }
            else if (SelectedFrequencyUnit1.UnitName == "Gigahertz" && SelectedFrequencyUnit2.UnitName == "Gigahertz")
            {
                // Formula to convert Gigahertz to Gigahertz = 1 to 1
                FrequencyUnit2 = FrequencyUnit1;
            }

            #endregion Gigahertz conversion
        }

        #endregion conversion logic for frequency

        #region conversion logic for mass

        /// <summary>
        /// Swapping SelectedMassUnit1 and SelectedMassUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapMassButtonClick(object sender)
        {
            Unit temporary1MassUnit;

            temporary1MassUnit = SelectedMassUnit1;
            SelectedMassUnit1 = SelectedMassUnit2;
            SelectedMassUnit2 = temporary1MassUnit;
        }

        public void MassConversion()
        {
            // Temporary storage to avoid loops
            temporaryMassUnit = MassUnit1;

            #region Tonne Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Tonne to Kilogram = Tonne * 1000
                MassUnit2 = MassUnit1 * 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Tonne to Gram = Tonne * 1000000
                MassUnit2 = MassUnit1 * 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Tonne to Milligam = Tonne * 1000000000
                MassUnit2 = MassUnit1 * 1000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Tonne to Microgram = Tonne * 1000000000000
                MassUnit2 = MassUnit1 * 1000000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Tonne to Imperial Ton = Tonne / 1.016
                MassUnit2 = MassUnit1 / 1.016;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Tonne to US Ton = Tonne * 1.102
                MassUnit2 = MassUnit1 * 1.102;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Tonne to Stone = Tonne * 157
                MassUnit2 = MassUnit1 * 157;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Tonne to Pound = Tonne * 2205
                MassUnit2 = MassUnit1 * 2205;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Tonne to Ounce = Tonne * 35274
                MassUnit2 = MassUnit1 * 35274;
            }
            else if (SelectedMassUnit1.UnitName == "Tonne" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Tonne to Tonne = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Tonne Conversion

            #region Kilogram Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Kilogram to Tonne = Kilogramm / 1000
                MassUnit2 = MassUnit1 / 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Kilogram to Gram = Kilogram * 1000
                MassUnit2 = MassUnit1 * 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Kilogram to Milligam = Kilogram * 1000000
                MassUnit2 = MassUnit1 * 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Kilogram to Microgram = Kilogram * 1000000000
                MassUnit2 = MassUnit1 * 1000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Kilogram to Imperial Ton = Kilogram / 1016
                MassUnit2 = MassUnit1 / 1016;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Kilogram to US Ton = Kilogram / 907
                MassUnit2 = MassUnit1 / 907;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Kilogram to Stone = Kilogram / 6.35
                MassUnit2 = MassUnit1 / 6.35;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Kilogram to Pound = Kilogram * 2.205
                MassUnit2 = MassUnit1 * 2.205;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Kilogram to Ounce = Kilogram * 35.274
                MassUnit2 = MassUnit1 * 35.274;
            }
            else if (SelectedMassUnit1.UnitName == "Kilogram" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Kilogram to Kilogram = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Kilogram Conversion

            #region Gram Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Gram to Tonne = Gram / 1000000
                MassUnit2 = MassUnit1 / 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Gram to Gram = Gram * 1000
                MassUnit2 = MassUnit1 / 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Gram to Milligam = Gram * 1000
                MassUnit2 = MassUnit1 * 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Gram to Microgram = Gram * 1000000
                MassUnit2 = MassUnit1 * 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Gram to Imperial Ton = Gram / 1016000
                MassUnit2 = MassUnit1 / 1016000;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Gram to US Ton = Gram / 907185
                MassUnit2 = MassUnit1 / 907185;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Gram to Stone = Gram / 6350
                MassUnit2 = MassUnit1 / 6350;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Gram to Pound = Gram / 454
                MassUnit2 = MassUnit1 / 454;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Gram to Ounce = Gram / 28.35
                MassUnit2 = MassUnit1 * 28.35;
            }
            else if (SelectedMassUnit1.UnitName == "Gram" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Gram to Gram = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Gram Conversion

            #region Milligram Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Milligram to Tonne = Milligram / 1000000000
                MassUnit2 = MassUnit1 / 1000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Milligram to Kilogram = Milligram / 1000000
                MassUnit2 = MassUnit1 / 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Milligram to Milligam = Milligram / 1000
                MassUnit2 = MassUnit1 / 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Milligram to Microgram = Milligram * 1000
                MassUnit2 = MassUnit1 * 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Milligram to Imperial Ton = Milligram / 1016000000
                MassUnit2 = MassUnit1 / 1016000000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Milligram to US Ton = Milligram / 907185000
                MassUnit2 = MassUnit1 / 907185000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Milligram to Stone = Milligram / 6350000
                MassUnit2 = MassUnit1 / 6350000;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Milligram to Pound = Milligram / 453592
                MassUnit2 = MassUnit1 / 453592;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Milligram to Ounce = Milligram / 28350
                MassUnit2 = MassUnit1 / 28350;
            }
            else if (SelectedMassUnit1.UnitName == "Milligram" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Milligram to Milligram = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Milligram Conversion

            #region Microgram Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Microgram to Tonne = Microgram / 1000000000000
                MassUnit2 = MassUnit1 / 1000000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Microgram to Kilogram = Microgram / 1000000000
                MassUnit2 = MassUnit1 / 1000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Microgram to Milligam = Microgram / 1000000
                MassUnit2 = MassUnit1 / 1000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Microgram to Microgram = Microgram / 1000
                MassUnit2 = MassUnit1 / 1000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Microgram to Imperial Ton = Microgram / 1016000000000
                MassUnit2 = MassUnit1 / 1016000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Microgram to US Ton = Microgram / 907185000000
                MassUnit2 = MassUnit1 / 907185000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Microgram to Stone = Microgram / 6350000000
                MassUnit2 = MassUnit1 / 6350000000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Microgram to Pound = Microgram / 453592000
                MassUnit2 = MassUnit1 / 453592000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Microgram to Ounce = Microgram / 28350000
                MassUnit2 = MassUnit1 / 28350000;
            }
            else if (SelectedMassUnit1.UnitName == "Microgram" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Microgram to Microgram = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Microgram Conversion

            #region Imperial Ton Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Imperial Ton to Tonne = Imperial Ton * 1.016
                MassUnit2 = MassUnit1 * 1.016;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Imperial Ton to Kilogram = Imperial Ton * 1016
                MassUnit2 = MassUnit1 * 1016;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Imperial Ton to Gram = Imperial Ton * 1016000
                MassUnit2 = MassUnit1 * 1016000;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Imperial Ton to Miligram = Imperial Ton * 1016000000
                MassUnit2 = MassUnit1 * 1016000000;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Imperial Ton to Microgram = Imperial Ton * 1016000000000
                MassUnit2 = MassUnit1 * 1016000000000;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Imperial Ton to US Ton = Imperial Ton * 1.12
                MassUnit2 = MassUnit1 * 1.12;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Imperial Ton to Stone = Imperial Ton * 160
                MassUnit2 = MassUnit1 * 160;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Imperial Ton to Pound = Imperial Ton * 2240
                MassUnit2 = MassUnit1 * 2240;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Imperial Ton to Ounce = Imperial Ton * 35840
                MassUnit2 = MassUnit1 * 35840;
            }
            else if (SelectedMassUnit1.UnitName == "Imperial Ton" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Imperial Ton to Imperial Ton = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Imperial Ton Conversion

            #region US Ton Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert US Ton to Tonne = US Ton / 1.102
                MassUnit2 = MassUnit1 / 1.102;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert US Ton to Kilogram = US Ton * 907
                MassUnit2 = MassUnit1 * 907;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert US Ton to Gram = US Ton * 907185
                MassUnit2 = MassUnit1 * 907185;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert US Ton to Miligram = US Ton * 907185000
                MassUnit2 = MassUnit1 * 907185000;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert US Ton to Microgram = US Ton * 907185000000
                MassUnit2 = MassUnit1 * 907185000000;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert US Ton to Imperial Ton = US Ton / 1.12
                MassUnit2 = MassUnit1 / 1.12;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert US Ton to Stone = US Ton * 143
                MassUnit2 = MassUnit1 * 143;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert US Ton to Pound = US Ton * 2000
                MassUnit2 = MassUnit1 * 2000;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert US Ton to Ounce = US Ton * 32000
                MassUnit2 = MassUnit1 * 32000;
            }
            else if (SelectedMassUnit1.UnitName == "US Ton" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert US Ton to US Ton = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion US Ton Conversion

            #region Stone Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Stone to Tonne = Stone / 157
                MassUnit2 = MassUnit1 / 157;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Stone to Kilogram = Stone * 6.35
                MassUnit2 = MassUnit1 * 6.35;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Stone to Gram = Stone * 6350
                MassUnit2 = MassUnit1 * 6350;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Stone to Miligram = Stone * 6350000
                MassUnit2 = MassUnit1 * 6350000;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Stone to Microgram = Stone * 6350000000
                MassUnit2 = MassUnit1 * 6350000000;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Stone to Imperial Ton = Stone / 160
                MassUnit2 = MassUnit1 / 160;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Stone to US Ton = Stone / 143
                MassUnit2 = MassUnit1 / 143;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Stone to Pound = Stone * 14
                MassUnit2 = MassUnit1 * 14;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Stone to Ounce = Stone * 224
                MassUnit2 = MassUnit1 * 224;
            }
            else if (SelectedMassUnit1.UnitName == "Stone" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Stone to Stone = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Stone Conversion

            #region Pound Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Pound to Tonne = Pound / 2205
                MassUnit2 = MassUnit1 / 2205;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Pound to Kilogram = Pound / 2.205
                MassUnit2 = MassUnit1 * 2.205;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Pound to Gram = Pound * 454
                MassUnit2 = MassUnit1 * 454;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Pound to Miligram = Pound * 453592
                MassUnit2 = MassUnit1 * 453592;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Pound to Microgram = Pound * 453592000
                MassUnit2 = MassUnit1 * 453592000;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Pound to Imperial Ton = Pound / 2240
                MassUnit2 = MassUnit1 / 2240;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Pound to Stone = Pound / 2000
                MassUnit2 = MassUnit1 / 2000;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Pound to Pound = Pound / 14
                MassUnit2 = MassUnit1 / 14;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Pound to Ounce = Pound * 16
                MassUnit2 = MassUnit1 * 16;
            }
            else if (SelectedMassUnit1.UnitName == "Pound" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Pound to Pound = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Pound Conversion

            #region Ounce Conversion

            // Conversion starts when SelectedMassUnit1 and SelectedMassUnit2 are initialized with mass units
            if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Tonne")
            {
                // Formula to convert Ounce to Tonne = Ounce / 35274
                MassUnit2 = MassUnit1 / 35274;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Kilogram")
            {
                // Formula to convert Ounce to Kilogram = Ounce / 35.274
                MassUnit2 = MassUnit1 * 35.274;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Gram")
            {
                // Formula to convert Ounce to Gram = Ounce * 28.35
                MassUnit2 = MassUnit1 * 28.35;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Milligram")
            {
                // Formula to convert Ounce to Miligram = Ounce * 28350
                MassUnit2 = MassUnit1 * 28350;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Microgram")
            {
                // Formula to convert Ounce to Microgram = Ounce * 28350000
                MassUnit2 = MassUnit1 * 28350000;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Imperial Ton")
            {
                // Formula to convert Ounce to Imperial Ton = Ounce / 35840
                MassUnit2 = MassUnit1 / 35840;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "US Ton")
            {
                // Formula to convert Ounce to Stone = Ounce / 32000
                MassUnit2 = MassUnit1 / 32000;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Stone")
            {
                // Formula to convert Ounce to Pound = Ounce / 224
                MassUnit2 = MassUnit1 / 224;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Pound")
            {
                // Formula to convert Ounce to Ounce = Ounce / 16
                MassUnit2 = MassUnit1 / 16;
            }
            else if (SelectedMassUnit1.UnitName == "Ounce" && SelectedMassUnit2.UnitName == "Ounce")
            {
                // Formula to convert Ounce to Ounce = 1 to 1
                MassUnit2 = MassUnit1;
            }

            #endregion Ounce Conversion
        }

        #endregion conversion logic for mass

        #region conversion logic for area

        /// <summary>
        /// Swapping SelectedAreaUnit1 and SelectedAreaUnit2
        /// </summary>
        /// <param name="sender"></param>
        private void SwapAreaButtonClick(object sender)
        {
            Unit temporaryAreaUnit;

            temporaryAreaUnit = SelectedAreaUnit1;
            SelectedAreaUnit1 = SelectedAreaUnit2;
            SelectedAreaUnit2 = temporaryAreaUnit;
        }

        public void AreaConversion()
        {
            // Temporary storage to avoid loops
            temporaryAreaUnit = AreaUnit1;

            #region Conversion from Squre kilometer to any

            // Conversion starts when SelectedAreaUnit1 and SelectedAreaUnit1 are initialized with mass units
            // Handeling conversion from square kilometer to square kilometer
            if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square kilometer to Hectare = Square kilometer * 100
                AreaUnit2 = AreaUnit1 * 100;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square kilometer to Square meter = Square kilometer * 1000000
                AreaUnit2 = AreaUnit1 * 1000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square kilometer to Square centimeter = Square kilometer * 10000000000
                AreaUnit2 = AreaUnit1 * 10000000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square kilometer to Square Mile = Square kilometer / 2.59
                AreaUnit2 = AreaUnit1 / 2.59;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square kilometer to Square acre = Square kilometer * 247
                AreaUnit2 = AreaUnit1 * 247;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square kilometer to Square yards = Square kilometer * 1196000
                AreaUnit2 = AreaUnit1 * 1196000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square kilometer to Square foot = Square kilometer * 10760000
                AreaUnit2 = AreaUnit1 * 10760000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square kilometer" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square kilometer to Square inch = Square kilometer * 1550000000
                AreaUnit2 = AreaUnit1 * 1550000000;
            }

            #endregion Conversion from Squre kilometer to any

            #region Conversion from Hectare to any

            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Hectare to Square kilometer = Hectare / 100
                AreaUnit2 = AreaUnit1 / 100;
            }
            // Handeling conversion from Hectare to Hectare
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Hectare to Square meter = Square kilometer * 10000
                AreaUnit2 = AreaUnit1 * 10000;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Hectare to Square centimeter = Square kilometer * 100000000
                AreaUnit2 = AreaUnit1 * 100000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Hectare to Square Mile = Square kilometer / 259
                AreaUnit2 = AreaUnit1 / 259;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Hectare to Square acre = Square kilometer * 2.471
                AreaUnit2 = AreaUnit1 * 2.471;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Hectare to Square yards = Square kilometer * 11960
                AreaUnit2 = AreaUnit1 * 11960;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Hectare to Square foot = Square kilometer * 107639
                AreaUnit2 = AreaUnit1 * 107639;
            }
            else if (SelectedAreaUnit1.UnitName == "Hectare" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Hectare to Square inch = Square kilometer * 15500000
                AreaUnit2 = AreaUnit1 * 15500000;
            }

            #endregion Conversion from Hectare to any

            #region Conversion from Square meter to any

            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square meter to Square kilometer = Square meter / 1000000
                AreaUnit2 = AreaUnit1 / 1000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square meter Hectare = Square meter / 10000
                AreaUnit2 = AreaUnit1 / 10000;
            }
            // Handeling conversion from Square meter to Square meter
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square meter to Square centimeter = Square meter * 10000
                AreaUnit2 = AreaUnit1 * 10000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square meter to Square Mile = Square meter / 2590000
                AreaUnit2 = AreaUnit1 / 2590000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square meter to Square acre = Square meter / 4047
                AreaUnit2 = AreaUnit1 / 4047;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square meter to Square yards = Square meter * 1.196
                AreaUnit2 = AreaUnit1 * 1.196;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square meter to Square foot = Square meter * 10.764
                AreaUnit2 = AreaUnit1 * 10.764;
            }
            else if (SelectedAreaUnit1.UnitName == "Square meter" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square meter to Square inch = Square meter * 1550
                AreaUnit2 = AreaUnit1 * 1550;
            }

            #endregion Conversion from Square meter to any

            #region Conversion from Square centimeter to any

            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square centimeter to Square kilometer = Square centimeter / 10000000000
                AreaUnit2 = AreaUnit1 / 10000000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square centimeter Hectare = Square centimeter / 100000000
                AreaUnit2 = AreaUnit1 / 100000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square centimeter to Square centimeter = Square centimeter / 10000
                AreaUnit2 = AreaUnit1 / 10000;
            }
            // Handeling conversion from Square centimeter to Square centimeter
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square centimeter to Square Mile = Square centimeter / 25900000000
                AreaUnit2 = AreaUnit1 / 25900000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square centimeter to Square acre = Square centimeter / 40470000
                AreaUnit2 = AreaUnit1 / 40470000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square centimeter to Square yards = Square centimeter / 8361
                AreaUnit2 = AreaUnit1 / 8361;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square centimeter to Square foot = Square centimeter / 929
                AreaUnit2 = AreaUnit1 / 929;
            }
            else if (SelectedAreaUnit1.UnitName == "Square centimeter" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square centimeter to Square inch = Square centimeter / 6.452
                AreaUnit2 = AreaUnit1 / 6.452;
            }

            #endregion Conversion from Square centimeter to any

            #region Conversion from Square mile to any

            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square mile to Square kilometer = Square mile * 2.59
                AreaUnit2 = AreaUnit1 * 2.59;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square mile Hectare = Square mile * 259
                AreaUnit2 = AreaUnit1 * 259;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square mile to Square meter = Square mile * 2590000
                AreaUnit2 = AreaUnit1 * 2590000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square mile to Square Mile = Square mile * 25900000000
                AreaUnit2 = AreaUnit1 * 25900000000;
            }
            // Handeling conversion from Square mile to Square mile
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square mile to Square acre = Square mile * 640
                AreaUnit2 = AreaUnit1 * 640;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square mile to Square yards = Square mile * 3098000
                AreaUnit2 = AreaUnit1 * 3098000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square mile to Square foot = Square mile * 27880000
                AreaUnit2 = AreaUnit1 * 27880000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square mile" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square mile to Square inch = Square mile * 4014000000
                AreaUnit2 = AreaUnit1 * 4014000000;
            }

            #endregion Conversion from Square mile to any

            #region Conversion from Acre to any

            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Acre to Square kilometer = Acre / 247
                AreaUnit2 = AreaUnit1 / 247;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Acre Hectare = Acre / 2.471
                AreaUnit2 = AreaUnit1 / 2.471;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Acre to Square meter = Acre * 4047
                AreaUnit2 = AreaUnit1 * 4047;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Acre to Square Mile = Acre * 40470000
                AreaUnit2 = AreaUnit1 * 40470000;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Acre to Square acre = Acre / 640
                AreaUnit2 = AreaUnit1 / 640;
            }
            // Handeling conversion from Acre to Acre
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Acre")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Acre to Square yards = Acre * 4840
                AreaUnit2 = AreaUnit1 * 4840;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Acre to Square foot = Acre * 43560
                AreaUnit2 = AreaUnit1 * 43560;
            }
            else if (SelectedAreaUnit1.UnitName == "Acre" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Acre to Square inch = Acre * 6273000
                AreaUnit2 = AreaUnit1 * 6273000;
            }

            #endregion Conversion from Acre to any

            #region Conversion from Square yard to any

            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square yard to Square kilometer = Square yard / 1196000
                AreaUnit2 = AreaUnit1 / 1196000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square yard Hectare = Square yard / 11960
                AreaUnit2 = AreaUnit1 / 11960;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square yard to Square meter = Square yard / 1.196
                AreaUnit2 = AreaUnit1 / 1.196;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square yard to Square Mile = Square yard * 8361
                AreaUnit2 = AreaUnit1 * 8361;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square yard to Square mile = Square yard / 3098000
                AreaUnit2 = AreaUnit1 / 3098000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square yard to Acre = Square yard / 4840
                AreaUnit2 = AreaUnit1 / 4840;
            }
            // Handeling conversion from Square yard to Square yard
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square yard to Square foot = Square yard * 9
                AreaUnit2 = AreaUnit1 * 9;
            }
            else if (SelectedAreaUnit1.UnitName == "Square yard" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square yard to Square inch = Square yard * 1296
                AreaUnit2 = AreaUnit1 * 1296;
            }

            #endregion Conversion from Square yard to any

            #region Conversion from Square foot to any

            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square foot to Square kilometer = Square foot / 10760000
                AreaUnit2 = AreaUnit1 / 10760000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square foot Hectare = Square foot / 107639
                AreaUnit2 = AreaUnit1 / 107639;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square foot to Square meter = Square foot / 10.764
                AreaUnit2 = AreaUnit1 / 10.764;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square foot to Square Mile = Square foot * 929
                AreaUnit2 = AreaUnit1 * 8361;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square foot to Square mile = Square foot / 27880000
                AreaUnit2 = AreaUnit1 / 27880000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square foot to Acre = Square foot / 43560
                AreaUnit2 = AreaUnit1 / 43560;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square foot to Square foot = Square foot / 9
                AreaUnit2 = AreaUnit1 / 9;
            }
            // Handeling conversion from Square foot to Square foot
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                AreaUnit2 = AreaUnit1;
            }
            else if (SelectedAreaUnit1.UnitName == "Square foot" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                // Formula to convert Square foot to Square inch = Square foot * 144
                AreaUnit2 = AreaUnit1 * 144;
            }

            #endregion Conversion from Square foot to any

            #region Conversion from Square inch to any

            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square kilometer")
            {
                // Formula to convert Square inch to Square kilometer = Square inch / 1550000000
                AreaUnit2 = AreaUnit1 / 1550000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Hectare")
            {
                // Formula to convert Square inch Hectare = Square inch / 15500000
                AreaUnit2 = AreaUnit1 / 15500000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square meter")
            {
                // Formula to convert Square inch to Square meter = Square inch / 1550
                AreaUnit2 = AreaUnit1 / 1550;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square centimeter")
            {
                // Formula to convert Square inch to Square Mile = Square inch * 6.452
                AreaUnit2 = AreaUnit1 * 6.452;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square mile")
            {
                // Formula to convert Square inch to Square mile = Square inch / 4014000000
                AreaUnit2 = AreaUnit1 / 4014000000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Acre")
            {
                // Formula to convert Square inch to Acre = Square inch / 6273000
                AreaUnit2 = AreaUnit1 / 6273000;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square yard")
            {
                // Formula to convert Square inch to Square foot = Square inch / 1296
                AreaUnit2 = AreaUnit1 / 1296;
            }
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square foot")
            {
                // Formula to convert Square inch to Square foot = Square inch / 144
                AreaUnit2 = AreaUnit1 / 144;
            }
            // Handeling conversion from Square inch to Square inch
            else if (SelectedAreaUnit1.UnitName == "Square inch" && SelectedAreaUnit2.UnitName == "Square inch")
            {
                AreaUnit2 = AreaUnit1;
            }

            #endregion Conversion from Square inch to any
        }

        #endregion conversion logic for area

        #region conversion logic for time

        public void SwapTimeButtonClick(object sender)
        {
            Unit temporaryTimeUnit;

            temporaryTimeUnit = SelectedTimeUnit1;
            SelectedTimeUnit1 = SelectedTimeUnit2;
            SelectedTimeUnit2 = temporaryTimeUnit;
        }

        public void TimeConversion()
        {
            temporaryTimeUnit = TimeUnit1;

            #region Conversion from Year to any

            // Handeling conversion from year to year
            if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Year")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Year = 12 months
                TimeUnit2 = TimeUnit1 * 12;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Year = 51.143 weeks
                TimeUnit2 = TimeUnit1 * 52.143;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Year = 365 days
                TimeUnit2 = TimeUnit1 * 365;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Year =  8760 hours
                TimeUnit2 = TimeUnit1 * 8760;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Year =  525600 minutes
                TimeUnit2 = TimeUnit1 * 525_600;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Year = 31540000 seconds
                TimeUnit2 = TimeUnit1 * 31_540_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Year" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Year = 31540000000 milliseconds
                TimeUnit2 = TimeUnit1 * 31_540_000_000;
            }

            #endregion Conversion from Year to any

            #region Conversion from Month to any

            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 12 Months = 1 year
                TimeUnit2 = TimeUnit1 / 12;
            }
            // Handeling conversion from Month to Month
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Month")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Month = 4.345 weeks
                TimeUnit2 = TimeUnit1 * 4.345;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Month = 30.417 days
                TimeUnit2 = TimeUnit1 * 30.417;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Month =  730.001 hours
                TimeUnit2 = TimeUnit1 * 730.001;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Month =  43800 minutes
                TimeUnit2 = TimeUnit1 * 43800;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Month = 2628000 seconds
                TimeUnit2 = TimeUnit1 * 2_628_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Month" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Month = 31540000000 milliseconds
                TimeUnit2 = TimeUnit1 * 2_628_000_000;
            }

            #endregion Conversion from Month to any

            #region Conversion from Week to any

            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Week = 0.0101781 year
                TimeUnit2 = TimeUnit1 / 52.143;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Week = 0.230137 month
                TimeUnit2 = TimeUnit1 / 4.345;
            }
            // Handeling conversion from Week to Week
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Week")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Week = 7 days
                TimeUnit2 = TimeUnit1 * 7;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Week =  168 hours
                TimeUnit2 = TimeUnit1 * 168;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Week =  10080 minutes
                TimeUnit2 = TimeUnit1 * 10080;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Week = 604_800 seconds
                TimeUnit2 = TimeUnit1 * 604_800;
            }
            else if (SelectedTimeUnit1.UnitName == "Week" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Week = 31540000000 milliseconds
                TimeUnit2 = TimeUnit1 * 604_800_000;
            }

            #endregion Conversion from Week to any

            #region Conversion from Day to any

            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Day = 0.00273973 year
                TimeUnit2 = TimeUnit1 / 365;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Day = 0.0328767 month
                TimeUnit2 = TimeUnit1 / 30.417;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Day = 0.142857
                TimeUnit2 = TimeUnit1 / 0.142857;
            }
            // Handeling conversion from Day to Day
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Day")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Day =  24 hours
                TimeUnit2 = TimeUnit1 * 24;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Day =  1440 minutes
                TimeUnit2 = TimeUnit1 * 1440;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Day = 86400 seconds
                TimeUnit2 = TimeUnit1 * 86400;
            }
            else if (SelectedTimeUnit1.UnitName == "Day" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Day = 86_400_000 milliseconds
                TimeUnit2 = TimeUnit1 * 86_400_000;
            }

            #endregion Conversion from Day to any

            #region Conversion from Hour to any

            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Hour = 0.000114155 year
                TimeUnit2 = TimeUnit1 / 8760;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Hour = 0.00136986 month
                TimeUnit2 = TimeUnit1 / 730;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Hour = 0.00595238 week
                TimeUnit2 = TimeUnit1 / 168;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Hour =  0.04166666 days
                TimeUnit2 = TimeUnit1 / 24;
            }
            // Handeling conversion from Hour to Hour
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Hour")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Hour =  60 minutes
                TimeUnit2 = TimeUnit1 * 60;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Hour = 86400 seconds
                TimeUnit2 = TimeUnit1 * 3600;
            }
            else if (SelectedTimeUnit1.UnitName == "Hour" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Hour = 86_400_000 milliseconds
                TimeUnit2 = TimeUnit1 * 3_600_000;
            }

            #endregion Conversion from Hour to any

            #region Conversion from Minute to any

            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Minute = 0.0000019026 year
                TimeUnit2 = TimeUnit1 / 525600;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Minute = 0.000022831 month
                TimeUnit2 = TimeUnit1 / 43800;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Minute = 0.000099206 week

                TimeUnit2 = TimeUnit1 / 10080;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Minute =  0.000694444 days
                TimeUnit2 = TimeUnit1 / 1440;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Minute =  0.0166667 hour
                TimeUnit2 = TimeUnit1 / 60;
            }
            // Handeling conversion from Minute to Minute
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Minute")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Minute = 60 seconds
                TimeUnit2 = TimeUnit1 * 60;
            }
            else if (SelectedTimeUnit1.UnitName == "Minute" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Minute = 60000 milliseconds
                TimeUnit2 = TimeUnit1 * 60_000;
            }

            #endregion Conversion from Minute to any

            #region Conversion from Second to any

            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Second = 0.00000003171 year
                TimeUnit2 = TimeUnit1 / 31_540_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Second = 0.00000038052 month
                TimeUnit2 = TimeUnit1 / 2_628_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Second = 0.0000016534 week

                TimeUnit2 = TimeUnit1 / 604_800;
            }
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Second =  0.00001574 days
                TimeUnit2 = TimeUnit1 / 86400;
            }
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Second =  0.000277778 hour
                TimeUnit2 = TimeUnit1 / 3600;
            }
            // Handeling conversion from Second to Second
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Second = 0.0166667 minute
                TimeUnit2 = TimeUnit1 / 60;
            }
            // Handeling conversion from Second to Second
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Second")
            {
                TimeUnit2 = TimeUnit1;
            }
            else if (SelectedTimeUnit1.UnitName == "Second" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                // 1 Second = 1000 milliseconds
                TimeUnit2 = TimeUnit1 * 1000;
            }

            #endregion Conversion from Second to any

            #region Conversion from Millisecond to any

            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Year")
            {
                // 1 Millisecond = 0.00000000003171 year
                TimeUnit2 = TimeUnit1 / 31_540_000_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Month")
            {
                // 1 Millisecond = 0.00000000038052 month
                TimeUnit2 = TimeUnit1 / 2_628_000_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Week")
            {
                // 1 Millisecond = 0.0000000016534 week

                TimeUnit2 = TimeUnit1 / 604_800_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Day")
            {
                // 1 Millisecond =  0.00000001574 days
                TimeUnit2 = TimeUnit1 / 86_400_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Hour")
            {
                // 1 Millisecond =  0.000000277778 hour
                TimeUnit2 = TimeUnit1 / 3_600_000;
            }
            // Handeling conversion from Second to Second
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Minute")
            {
                // 1 Millisecond = 0.0000166667 minute
                TimeUnit2 = TimeUnit1 / 60_000;
            }
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Second")
            {
                // 1 Second = 0.001 milliseconds
                TimeUnit2 = TimeUnit1 / 1000;
            }
            // Handeling conversion from Millisecond to Millisecond
            else if (SelectedTimeUnit1.UnitName == "Millisecond" && SelectedTimeUnit2.UnitName == "Millisecond")
            {
                TimeUnit2 = TimeUnit1;
            }

            #endregion Conversion from Millisecond to any
        }

        #endregion conversion logic for time
    }
}