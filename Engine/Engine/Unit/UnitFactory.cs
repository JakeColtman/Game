using Engine.Mappings;
using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{
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

        public IUnit create(ICoordinate<TwoD> coord, Stats stats, IWeapon weapon)
        {
            if (_readMap.get_item_at_coord(coord) != null)
            {
                throw new ArgumentOutOfRangeException("Pos already exists");
            }

            IMoveable<TwoD> movementHandler = new TwoDMovementHandler(_bus, coord);

            return new Unit(stats, weapon, movementHandler);
        }

    }
}
