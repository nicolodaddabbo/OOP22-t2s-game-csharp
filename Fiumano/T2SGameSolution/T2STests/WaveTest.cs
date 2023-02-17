using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T2STests
{
    [TestClass]
    public class WaveTest
    {
        private IWaveFactory waveFactory = new WaveFactory();
        private const int Round = 10;

        [TestMethod]
        public void TestBasicWaveSpawn()
        {
            var wave = waveFactory.CreateBasicWave(Round);
            Assert.IsFalse(!wave.GetEnemies()?.Any());
            Assert.AreEqual(Round / 2, wave.GetEnemies().Count);
        }

        [TestMethod]
        public void TestBossWaveSpawn()
        {
            var wave = waveFactory.CreateBossWave(Round);
            Assert.IsFalse(!wave.GetEnemies()?.Any());
            Assert.AreEqual(Round / 4 + 1, wave.GetEnemies().Count);
        }

        [TestMethod]
        public void TestAddEntityToWave()
        {
            var wave = waveFactory.CreateBasicWave(0);
            Assert.IsTrue(!wave.GetEnemies()?.Any());
            wave.AddEnemy(new Entity());
            Assert.IsFalse(!wave.GetEnemies()?.Any());
        }
    }
}