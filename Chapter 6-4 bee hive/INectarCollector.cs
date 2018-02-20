using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    interface INectarCollector
    {
        #region Methods

        void FindFlowers();

        void GatherNectar();

        void ReturnToHive();

        #endregion
    }
}
