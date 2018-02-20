using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public int AlertLevel => throw new NotImplementedException();

        public int StingerLegth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FindFlowers()
        {
            throw new NotImplementedException();
        }

        public void GatherNectar()
        {
            throw new NotImplementedException();
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public void ReturnToHive()
        {
            throw new NotImplementedException();
        }

        public int SharpernStinger(int Length)
        {
            throw new NotImplementedException();
        }
    }
}
