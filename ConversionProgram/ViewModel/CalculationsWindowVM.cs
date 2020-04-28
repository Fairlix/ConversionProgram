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
    public class CalculationsWindowVM : ViewModelBase
    {
        #region Private members

        private double _fuelprice;
        private double _distanceDriven;
        private double _litersPer100km;
        private double _resultFuelCost;
        private double _fuelPriceTemporary;
        private double _distanceDrivenTemporary;
        private double _litersPer100kmTemporary;

        private double _litersUsed;
        private double _distanceDrivenFuelEconomy;
        private double _resultLitersPer100km;
        private double _litersUsedTemporary;
        private double _distanceDrivenFuelEconomyTemporary;

        private double _wattConsumption;
        private double _utilizationTime;
        private double _energyCost;
        private double _resultEnergyCost;
        private double _wattConsumptionTemporary;
        private double _utilizationTimeTemporary;
        private double _energyCostTemporay;

        private double _massKineticEnergy;
        private double _velocityKineticEnergy;
        private double _resultKineticEnergy;
        private double _temporaryMassKineticEnergy;
        private double _temporaryVelocityKineticEnergy;

        private double _bodyWeight;
        private double _bodyHeight;
        private double _resultBodyMassIndex;
        private string _resultBodyMassIndexText;
        private double _temporaryBodyWeight;
        private double _temporaryBodyHeight;
        private Unit _selectedMassUnit;
        private Unit _selectedVelocityUnit;

        #endregion Private members

        #region Random number generator

        private int _minimalRandomNumber;
        private int _maximalRandomNumber;
        private string _randomNumberResult = "0";
        public ICommand GenerateRandomNumberCommand { get; set; }

        #endregion Random number generator

        #region Date difference calculator

        private DateTime _daysPassedFirstDate = DateTime.Now;
        private DateTime _daysPassedSecondDate = DateTime.Now;
        private double _daysPassedTotalDays;
        public ICommand CalculateDateDifferenceCommand { get; set; }

        #endregion Date difference calculator

        #region Properties fuel cost

        public double FuelPrice
        {
            get { return _fuelprice; }
            set
            {
                Set(ref _fuelprice, value);

                if (FuelPrice != _fuelPriceTemporary)
                {
                    CalculateFuelCost();
                }
            }
        }

        public double DistanceDriven
        {
            get { return _distanceDriven; }
            set
            {
                Set(ref _distanceDriven, value);

                if (DistanceDriven != _distanceDrivenTemporary)
                {
                    CalculateFuelCost();
                }
            }
        }

        public double LitersPer100km
        {
            get { return _litersPer100km; }
            set
            {
                Set(ref _litersPer100km, value);

                if (LitersPer100km != _litersPer100kmTemporary)
                {
                    CalculateFuelCost();
                }
            }
        }

        public double ResultFuelCost
        {
            get { return _resultFuelCost; }
            set
            {
                Set(ref _resultFuelCost, value);
            }
        }

        #endregion Properties fuel cost

        #region Properties fuel economy

        public double LitersUsed
        {
            get { return _litersUsed; }
            set
            {
                Set(ref _litersUsed, value);

                if (LitersUsed != _litersUsedTemporary)
                {
                    CalculateFuelEconomy();
                }
            }
        }

        public double DistanceDrivenFuelEconomy
        {
            get { return _distanceDrivenFuelEconomy; }
            set
            {
                Set(ref _distanceDrivenFuelEconomy, value);

                if (DistanceDrivenFuelEconomy != _distanceDrivenFuelEconomyTemporary)
                {
                    CalculateFuelEconomy();
                }
            }
        }

        public double ResultLitersPer100km
        {
            get { return _resultLitersPer100km; }

            set
            {
                Set(ref _resultLitersPer100km, value);
            }
        }

        #endregion Properties fuel economy

        #region Properties for energy cost

        public double WattConsumption
        {
            get { return _wattConsumption; }
            set
            {
                Set(ref _wattConsumption, value);

                if (WattConsumption != _wattConsumptionTemporary)
                {
                    CalculateEnergyCost();
                }
            }
        }

        public double UtilizationTime
        {
            get { return _utilizationTime; }
            set
            {
                Set(ref _utilizationTime, value);

                if (UtilizationTime != _utilizationTimeTemporary)
                {
                    CalculateEnergyCost();
                }
            }
        }

        public double EnergyCost
        {
            get { return _energyCost; }
            set
            {
                Set(ref _energyCost, value);

                if (EnergyCost != _energyCostTemporay)
                {
                    CalculateEnergyCost();
                }
            }
        }

        public double ResultEnergyCost
        {
            get { return _resultEnergyCost; }
            set
            {
                Set(ref _resultEnergyCost, value);

                if (ResultEnergyCost != _resultEnergyCost)
                {
                    CalculateEnergyCost();
                }
            }
        }

        #endregion Properties for energy cost

        #region Properties for kinetic energy

        public ObservableCollection<Unit> MassUnitList { get; set; }
        public ObservableCollection<Unit> VelocityUnitList { get; set; }

        public double MassKineticEnergy
        {
            get { return _massKineticEnergy; }
            set
            {
                Set(ref _massKineticEnergy, value);

                if (MassKineticEnergy != 0)
                {
                    CalculateKineticEnergy();
                }
            }
        }

        public double VelocityKineticEnergy
        {
            get { return _velocityKineticEnergy; }
            set
            {
                Set(ref _velocityKineticEnergy, value);

                if (VelocityKineticEnergy != 0)
                {
                    CalculateKineticEnergy();
                }
            }
        }

        public double ResultKineticEnergy
        {
            get { return _resultKineticEnergy; }
            set
            {
                if (ResultKineticEnergy != _resultKineticEnergy)
                {
                    CalculateKineticEnergy();
                }
                Set(ref _resultKineticEnergy, value);
            }
        }

        public Unit SelectedMassUnit
        {
            get { return _selectedMassUnit; }
            set
            {
                Set(ref _selectedMassUnit, value);

                if (SelectedMassUnit != null && SelectedVelocityUnit != null)
                {
                    CalculateKineticEnergy();
                }
            }
        }

        public Unit SelectedVelocityUnit
        {
            get { return _selectedVelocityUnit; }
            set
            {
                Set(ref _selectedVelocityUnit, value);

                if (SelectedMassUnit != null && SelectedVelocityUnit != null)
                {
                    CalculateKineticEnergy();
                }
            }
        }

        #endregion Properties for kinetic energy

        #region Properties for Body Mass Index

        public double BodyWeight
        {
            get { return _bodyWeight; }
            set
            {
                Set(ref _bodyWeight, value);

                if (BodyWeight != _temporaryBodyWeight && BodyHeight != 0)
                {
                    CalculateBodyMassIndex();
                }
            }
        }

        public double BodyHeight
        {
            get { return _bodyHeight; }
            set
            {
                Set(ref _bodyHeight, value);

                if (BodyHeight != _temporaryBodyHeight && BodyWeight != 0)
                {
                    CalculateBodyMassIndex();
                }
            }
        }

        public double ResultBodyMassIndex
        {
            get { return _resultBodyMassIndex; }
            set
            {
                if (ResultBodyMassIndex != _resultBodyMassIndex)
                {
                    CalculateBodyMassIndex();
                }

                Set(ref _resultBodyMassIndex, value);
            }
        }

        public string ResultBodyMassIndexText
        {
            get { return _resultBodyMassIndexText; }
            set
            {
                //if (ResultBodyMassIndexText != _resultBodyMassIndexText)
                //{
                //}
                Set(ref _resultBodyMassIndexText, value);
            }
        }

        #endregion Properties for Body Mass Index

        #region Properties for Random Number Generator

        public int MinimalRandomNumber
        {
            get { return _minimalRandomNumber; }
            set
            {
                Set(ref _minimalRandomNumber, value);

                if (MinimalRandomNumber != 0 && MaximumRandomNumber != 0)
                {
                    GenerateRandomNumber();
                }
            }
        }

        public int MaximumRandomNumber
        {
            get { return _maximalRandomNumber; }
            set
            {
                Set(ref _maximalRandomNumber, value);

                if (MinimalRandomNumber != 0 && MaximumRandomNumber != 0)
                {
                    GenerateRandomNumber();
                }
            }
        }

        public string RandomNumberResult
        {
            get { return _randomNumberResult; }
            set
            {
                Set(ref _randomNumberResult, value);
            }
        }

        #endregion Properties for Random Number Generator

        #region Properties for Days passed

        public DateTime DaysPassedFirstDate
        {
            get { return _daysPassedFirstDate; }
            set
            {
                Set(ref _daysPassedFirstDate, value);
            }
        }

        public DateTime DaysPassedSecondDate
        {
            get { return _daysPassedSecondDate; }
            set
            {
                Set(ref _daysPassedSecondDate, value);
            }
        }

        public double DaysPassedTotalDays
        {
            get { return _daysPassedTotalDays; }
            set
            {
                Set(ref _daysPassedTotalDays, value);
            }
        }

        #endregion Properties for Days passed

        /// <summary>
        /// Constructor initializing lists and commands
        /// </summary>
        public CalculationsWindowVM()
        {
            // Filling MassUnitList with units
            MassUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Tonne", UnitAcronym = "t", UnitId = 1, UnitNameAndAcronym = "t - Tonne"},
                new Unit(){UnitName = "Kilogram", UnitAcronym = "kg", UnitId = 2, UnitNameAndAcronym = "kg - Kilogram"},
                new Unit(){UnitName = "Gram", UnitAcronym = "g", UnitId = 3, UnitNameAndAcronym = "g - Gram"},
                new Unit(){UnitName = "Imperial Ton", UnitAcronym = "long ton", UnitId = 4, UnitNameAndAcronym = "long ton - Imperial Ton"},
                new Unit(){UnitName = "Pound", UnitAcronym = "lb", UnitId = 5, UnitNameAndAcronym = "short ton - US Ton"},
                new Unit(){UnitName = "Ounce", UnitAcronym = "oz", UnitId = 6, UnitNameAndAcronym = "oz - Ounce"}
            };

            // Filling VelocityUnitList with units
            VelocityUnitList = new ObservableCollection<Unit>()
            {
                new Unit(){UnitName = "Kilometer per hour", UnitAcronym = "kp/h", UnitId = 10, UnitNameAndAcronym = "kp/h - Kilometer per hour"},
                new Unit(){UnitName = "Meter per second", UnitAcronym = "m/s", UnitId = 11, UnitNameAndAcronym = "m/s - Meter per second"},

                new Unit(){UnitName = "Mile per hour", UnitAcronym = "mi/h", UnitId = 12, UnitNameAndAcronym = "mi/h - Mile per hour"},
                new Unit(){UnitName = "Foot per second", UnitAcronym = "ft/s", UnitId = 13, UnitNameAndAcronym = "ft/s - Foot per second"}
            };

            // Relay commands
            GenerateRandomNumberCommand = new RelayCommand(() => GenerateRandomNumber());
            CalculateDateDifferenceCommand = new RelayCommand(() => CalculateDateDifference());
        }

        /// <summary>
        /// Method to calculate the fuel cost of a traveled distance
        /// </summary>
        public void CalculateFuelCost()
        {
            // temporary storage to avoid loops
            _fuelPriceTemporary = FuelPrice;
            _distanceDrivenTemporary = DistanceDriven;
            _litersPer100kmTemporary = LitersPer100km;

            // Formula to calculate fuel costs
            ResultFuelCost = (LitersPer100km * (DistanceDriven / 100)) * FuelPrice;
        }

        /// <summary>
        /// Method to calculate fuel economy
        /// </summary>
        public void CalculateFuelEconomy()
        {
            // temporary storage to avoid loops
            _litersUsedTemporary = LitersUsed;
            _distanceDrivenFuelEconomyTemporary = DistanceDrivenFuelEconomy;

            // Formula to calculate fuel economy
            ResultLitersPer100km = (LitersUsed / (DistanceDrivenFuelEconomy / 100));
        }

        /// <summary>
        /// Method to calculate energy cost of an electrical item
        /// </summary>
        public void CalculateEnergyCost()
        {   // temporary storage to avoid loops
            _wattConsumptionTemporary = WattConsumption;
            _utilizationTimeTemporary = UtilizationTime;
            _energyCostTemporay = EnergyCost;

            // Formula to calculate energy costs
            ResultEnergyCost = (WattConsumption / 1000) * UtilizationTime * EnergyCost;
        }

        /// <summary>
        /// Method to calculate kinetic energy
        /// </summary>
        public void CalculateKineticEnergy()
        {
            // temporary storage to avoid loops
            _temporaryMassKineticEnergy = MassKineticEnergy;
            _temporaryVelocityKineticEnergy = VelocityKineticEnergy;

            // Basic formula to calculate energy in joules from grams and m/s
            //ResultKineticEnergy = (0.5 * MassKineticEnergy) * (VelocityKineticEnergy * VelocityKineticEnergy);

            if (MassKineticEnergy != 0 && VelocityKineticEnergy != 0 && SelectedVelocityUnit != null && SelectedMassUnit != null)
            {
                #region calculating kinetic energy Kilometer per hour

                if (SelectedMassUnit.UnitName == "Tonne" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1000) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }
                else if (SelectedMassUnit.UnitName == "Kilogram" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = (0.5 * MassKineticEnergy) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }
                else if (SelectedMassUnit.UnitName == "Gram" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 1000) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }
                else if (SelectedMassUnit.UnitName == "Imperial Ton" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1016) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }
                else if (SelectedMassUnit.UnitName == "Pound" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 2.205) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }
                else if (SelectedMassUnit.UnitName == "Ounce" && SelectedVelocityUnit.UnitName == "Kilometer per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 35.274) * ((VelocityKineticEnergy / 3.6) * (VelocityKineticEnergy / 3.6));
                }

                #endregion calculating kinetic energy Kilometer per hour

                #region calculating kinetic energy  Meter per second

                else if (SelectedMassUnit.UnitName == "Tonne" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1000) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }
                else if (SelectedMassUnit.UnitName == "Kilogram" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = (0.5 * MassKineticEnergy) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }
                else if (SelectedMassUnit.UnitName == "Gram" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 1000) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }
                else if (SelectedMassUnit.UnitName == "Imperial Ton" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1016) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }
                else if (SelectedMassUnit.UnitName == "Pound" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 2.205) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }
                else if (SelectedMassUnit.UnitName == "Ounce" && SelectedVelocityUnit.UnitName == "Meter per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 35.274) * (VelocityKineticEnergy * VelocityKineticEnergy);
                }

                #endregion calculating kinetic energy  Meter per second

                #region calculating kinetic energy  Mile per hour

                else if (SelectedMassUnit.UnitName == "Tonne" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1000) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }
                else if (SelectedMassUnit.UnitName == "Kilogram" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = (0.5 * MassKineticEnergy) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }
                else if (SelectedMassUnit.UnitName == "Gram" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 1000) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }
                else if (SelectedMassUnit.UnitName == "Imperial Ton" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1016) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }
                else if (SelectedMassUnit.UnitName == "Pound" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 2.205) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }
                else if (SelectedMassUnit.UnitName == "Ounce" && SelectedVelocityUnit.UnitName == "Mile per hour")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 35.274) * ((VelocityKineticEnergy / 2.237) * (VelocityKineticEnergy / 2.237));
                }

                #endregion calculating kinetic energy  Mile per hour

                #region calculating kinetic energy Foot per hour

                else if (SelectedMassUnit.UnitName == "Tonne" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1000) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }
                else if (SelectedMassUnit.UnitName == "Kilogram" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = (0.5 * MassKineticEnergy) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }
                else if (SelectedMassUnit.UnitName == "Gram" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 1000) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }
                else if (SelectedMassUnit.UnitName == "Imperial Ton" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) * 1016) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }
                else if (SelectedMassUnit.UnitName == "Pound" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 2.205) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }
                else if (SelectedMassUnit.UnitName == "Ounce" && SelectedVelocityUnit.UnitName == "Foot per second")
                {
                    ResultKineticEnergy = ((0.5 * MassKineticEnergy) / 35.274) * ((VelocityKineticEnergy / 3.281) * (VelocityKineticEnergy / 3.281));
                }

                #endregion calculating kinetic energy Foot per hour
            }
        }

        /// <summary>
        /// Method to calculate the body mass index to roughly determine obesity
        /// </summary>
        public void CalculateBodyMassIndex()
        {
            // Temporary storage to avoid loops
            _temporaryBodyWeight = BodyWeight;
            _temporaryBodyHeight = BodyHeight;
            // _temporaryResultBodyMassIndex = ResultBodyMassIndex;

            // Calculating BMI
            ResultBodyMassIndex = BodyWeight / ((BodyHeight / 100) * (BodyHeight / 100));

            // Giving the user additional information based off is his BMI
            if (ResultBodyMassIndex < 19)
            {
                ResultBodyMassIndexText = "Underweight";
            }
            else if (ResultBodyMassIndex > 19 && ResultBodyMassIndex <= 25)
            {
                ResultBodyMassIndexText = "Normal weight";
            }
            else if (ResultBodyMassIndex > 25 && ResultBodyMassIndex <= 30)
            {
                ResultBodyMassIndexText = "Slightly obese";
            }
            else if (ResultBodyMassIndex > 30 && ResultBodyMassIndex <= 40)
            {
                ResultBodyMassIndexText = "Obese";
            }
            else if (ResultBodyMassIndex > 40)
            {
                ResultBodyMassIndexText = "Severly obese";
            }
        }

        /// <summary>
        /// Generate a random number between a given range of numbers
        /// </summary>
        public void GenerateRandomNumber()
        {
            // Checks if minValue is greater than maxValue, if true inform user about error
            if (MinimalRandomNumber < MaximumRandomNumber)
            {
                Random rdm = new Random();
                int temporaryRandomNumber = rdm.Next(MinimalRandomNumber, MaximumRandomNumber + 1);
                RandomNumberResult = Convert.ToString(temporaryRandomNumber);
            }
            else if (MinimalRandomNumber > MaximumRandomNumber)
            {
                RandomNumberResult = "Error: check values";
            }
        }

        /// <summary>
        /// Method to calulate the number of days between 2 days
        /// </summary>
        public void CalculateDateDifference()
        {
            DaysPassedTotalDays = (DaysPassedSecondDate - DaysPassedFirstDate).Days;
        }
    }
}