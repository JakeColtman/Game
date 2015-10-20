using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    //[TestClass]
    //public class Unit
    //{

    //    Engine.UnitFactory factory;
    //    Engine.WeaponFactory weaponFactory;

    //    [TestInitialize]
    //    public void setup()
    //    {
    //        factory = new Engine.UnitFactory();
    //        weaponFactory = new Engine.WeaponFactory();
    //    }

    //    [TestMethod]
    //    public void FactoryCreatesUnit()
    //    {
    //        Engine.IUnit lanceman = factory.create(10, 11, 12, weaponFactory.create(Engine.WeaponType.Lance, 1, 2));
    //        Assert.AreEqual(lanceman.get_weapon().get_power(), 2);
    //        Assert.AreEqual(lanceman.get_weapon().get_type(), Engine.WeaponType.Lance);
    //        Assert.AreEqual(lanceman.get_health(), 10);
    //    }

    //    [TestMethod]
    //    public void AddingNewWeaponChangesWeapon()
    //    {
    //        Engine.IWeapon axe = weaponFactory.create(Engine.WeaponType.Axe, 1, 2);
    //        Engine.IWeapon lance = weaponFactory.create(Engine.WeaponType.Lance, 1, 2);
    //        Engine.IUnit unit = factory.create(10, 11, 12,lance);
    //        unit.give_weapon(axe);
    //        Assert.AreEqual(unit.get_weapon(), axe);
            
    //    }

    //}
}
