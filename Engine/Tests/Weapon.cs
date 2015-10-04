using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;

namespace Tests
{
    [TestClass]
    public class Weapon
    {

        WeaponFactory factory;

        [TestInitialize]
        public void setup()
        {
           factory = new WeaponFactory();
        }

        [TestMethod]
        public void FactoryCreateWeapon()
        {
            IWeapon axe = factory.create(WeaponType.Axe, 10, 100);

            Assert.AreEqual(axe.get_type(), WeaponType.Axe);
            Assert.AreEqual(axe.get_power(), 10);
            Assert.AreEqual(axe.get_weight(), 100);

        }
    }
}
