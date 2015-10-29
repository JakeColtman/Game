//using Engine.Mappings.Coordinates;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Engine.Unit
//{



//    public interface IUnit
//    {
//        void attack(IUnit attackedBy);
//        bool give_weapon(IWeapon newWeapon);
//        IStatsReader get_stats_reader();
//        IStatsUpdater get_stats_updater();
//        IWeapon get_weapon();
//        IMoveable<TwoD> get_movement();
//    }



//    public class Unit : IUnit
//    {
//        IWeapon weapon;
//        IMoveable<TwoD> movement;
//        IStatsUpdater _statsUpdater;
//        IStatsReader _statsReader;

//        public Unit(IStatsUpdater statsUpdater, IStatsReader statsReader, IWeapon weapon, IMoveable<TwoD> movementHandler)
//        {
//            _statsReader = statsReader;
//            _statsUpdater = statsUpdater;
//            this.weapon = weapon;
//            this.movement = movementHandler;
//        }

//        public void attack(IUnit attackedBy)
//        {
//            throw new NotImplementedException();
//        }

//        public bool give_weapon(IWeapon newWeapon)
//        {
//            try {
//                this.weapon = newWeapon;
//                return true;
//            }
//            catch
//            {
//                return false;
//            }

//        }

//        public IWeapon get_weapon()
//        {
//            return this.weapon;
//        }

//        public IMoveable<TwoD> get_movement()
//        {
//            return movement;
//        }

//        public IStatsReader get_stats_reader()
//        {
//            return _statsReader;
//        }

//        public IStatsUpdater get_stats_updater()
//        {
//            return _statsUpdater;
//        }
//    }
//}
