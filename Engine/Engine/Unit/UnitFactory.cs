using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{
    public class UnitFactory
    {

        Mappings.IMapUpdatable _writeMap;
        Mappings.IMapUpdateReadable<IUnit> _readMap;

        public UnitFactory(Mappings.IMapUpdatable updateMap, Mappings.IMapUpdateReadable<IUnit> readMap)
        {
            _writeMap = updateMap;
            _readMap = readMap;
        }

        public IUnit create(Mappings.ICoordinate coord, Stats stats, IWeapon weapon)
        {
            if (_readMap.pos_exists(coord))
            {
                throw new ArgumentOutOfRangeException("Pos already exists");
            }

            IMoveable movementHandler = new MovementHandler(coord);
            movementHandler.add_movement_subscriber(_writeMap);

            return new Unit(stats, weapon, movementHandler);
        }

    }
}
