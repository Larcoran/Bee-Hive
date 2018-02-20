using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    interface IStingPatrol
    {
        #region Properties

        int AlertLevel { get; }
        int StingerLegth { get; set; }

        #endregion

        #region Methods

        int SharpernStinger(int Length);

        bool LookForEnemies();

        #endregion
    }
}
