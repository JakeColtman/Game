using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{

    public interface IStatsReader
    {

        int get_health();
        int get_stength();
        int get_defence();

    }

    public interface IStatsUpdater
    {
        bool attack_with_stats(IStatsReader attackerStats);
        bool heal_with_stats(IStatsReader healerStats);
    }


    public class SimpleStats : IStatsReader, IStatsUpdater
    {

        int _health;
        int _strength;
        int _defence;

        public int get_stength()
        {
            return _strength;
        }

        public int get_health()
        {
            return _health;
        }

        public int get_defence()
        {
            return _defence;
        }

        public bool attack_with_stats(IStatsReader attackerStats)
        {
            _health -= attackerStats.get_stength();
            return true;
        }

        public bool heal_with_stats(IStatsReader healerStats)
        {
            _health += healerStats.get_stength();
            return true;
        }
    }
}
