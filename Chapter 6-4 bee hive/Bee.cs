using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    class Bee
    {
        #region Const

        public const double HoneyUnitsConsumedPerMg = .25;

        #endregion

        #region Properties

        public double WeightMg { get; private set;}

        #endregion

        #region Constructor

        public Bee (double weightMg)
        {
            WeightMg = weightMg;
        }

        #endregion

        #region Virtual Methods

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }

        #endregion
    }
}
