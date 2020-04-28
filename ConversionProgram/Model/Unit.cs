using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionProgram.Model
{
    public class Unit : ModelBase
    {
        #region Private members

        private string _unitName;
        private string _unitAcronym;
        private int _unitId;
        private string _unitNameAndAcronym;

        #endregion Private members

        #region Properties

        /// <summary>
        /// Name of the unit
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { Set(ref _unitName, value); }
        }

        /// <summary>
        /// Acronym of the unit
        /// </summary>
        public string UnitAcronym
        {
            get { return _unitAcronym; }
            set { Set(ref _unitAcronym, value); }
        }

        /// <summary>
        /// Id of the unit
        /// </summary>
        public int UnitId
        {
            get { return _unitId; }
            set { Set(ref _unitId, value); }
        }

        /// <summary>
        /// Unit name and according acronym
        /// </summary>
        public string UnitNameAndAcronym
        {
            get { return _unitNameAndAcronym; }
            set { Set(ref _unitNameAndAcronym, value); }
        }

        #endregion Properties
    }
}