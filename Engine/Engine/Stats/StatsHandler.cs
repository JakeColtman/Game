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
    }


    public class SimpleStats : IStatsReader
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
    }
}
