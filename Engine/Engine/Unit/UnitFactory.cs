using Engine.Mappings;
using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{

    public interface IUnitFactory<TInstruction, TOutput>
    {
        TOutput create(TInstruction instruction);
    }

    public class UnitFactory
    {

        Mappings.IMapWriteable<TwoD, IUnit> _writeMap;
        Mappings.IMapReadable<TwoD, IUnit> _readMap;
        Movement.IMovementBus<TwoD> _bus;

        public UnitFactory(IMapWriteable<TwoD, IUnit> writeMap, IMapReadable<TwoD, IUnit> readMap, Movement.IMovementBus<TwoD> bus)
        {
            _writeMap = writeMap;
            _readMap = readMap;
            _bus = bus;
        }

        public IUnit create(ICoordinate<TwoD> coord, IStatsReader stats_reader, IStatsUpdater stats_updater, IWeapon weapon)
        {
            if (_readMap.get_item_at_coord(coord) != null)
            {
                throw new ArgumentOutOfRangeException("Pos already exists");
            }

            IMoveable<TwoD> movementHandler = new TwoDMovementHandler(_bus, coord);

            var newUnit = new Unit(stats_updater, stats_reader, weapon, movementHandler);

           _writeMap.add_to_coord(coord, newUnit);
            return newUnit;
        }

    }
}
