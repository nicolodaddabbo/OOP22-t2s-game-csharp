using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/// disabled warning CS8602 Dereference of a possibly null reference, 
/// the value will never be null because is setted before the dereference 
#pragma warning disable CS8602
namespace T2STests
{
    [TestClass]
    public class PowerUpTest
    {
        private IPowerUpFactory _powerUpFactory = new PowerUpFactory();
        private const double FireRateSeconds = 1.5;
        private const double ProjectileSpeed = 1.0;
        private const int ProjectileDamage = 1;
        private const double ProjectileSize = 20;
        private const int Health = 3;
        private const double Speed = 1;
        private const double FireRateSecondsPowerUp = 0.05;
        private const double ProjectileSpeedPowerUp = 0.5;
        private const int ProjectileDamagePowerUp = 1;
        private const double ProjectileSizePowerUp = 5;
        private const int HealthPowerUp = 1;
        private const double SpeedPowerUp = 0.25;
        private IEntity CreateBasePlayerEntity()
        {
            var entity = new Entity();
            entity.AddComponent(new HealthComponent(Health));
            entity.AddComponent(new ShootComponent(FireRateSeconds, ProjectileSpeed, ProjectileDamage, ProjectileSize));
            entity.AddComponent(new PhysicsComponent(Speed));

            return entity;
        }

        [TestMethod]
        public void TestHealthUpPowerUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<HealthComponent>();
            _powerUpFactory.GenerateHealthUpPowerUp().Obtain(entity);
            Assert.AreEqual(Health + HealthPowerUp, component.Health);
        }

        [TestMethod]
        public void TestDamageBoostPowerUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<ShootComponent>();
            _powerUpFactory.GenerateDamageBoostPowerUp().Obtain(entity);
            Assert.AreEqual(ProjectileDamage + ProjectileDamagePowerUp, component.ProjectileDamage);
        }

        [TestMethod]
        public void TestFireRatioPowerUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<ShootComponent>();
            _powerUpFactory.GenerateFireRatioPowerUp().Obtain(entity);
            Assert.AreEqual(FireRateSeconds + FireRateSecondsPowerUp, component.FireRateSeconds);
        }

        [TestMethod]
        public void TestSpeedUpPowerUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<PhysicsComponent>();
            _powerUpFactory.GenerateSpeedUpPowerUp().Obtain(entity);
            Assert.AreEqual(Speed + SpeedPowerUp, component.Speed);
        }

        [TestMethod]
        public void TestProjectileSpeedUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<ShootComponent>();
            _powerUpFactory.GenerateProjectileSpeedUpPowerUp().Obtain(entity);
            Assert.AreEqual(ProjectileSpeed + ProjectileSpeedPowerUp, component.ProjectileSpeed);
        }

        [TestMethod]
        public void TestProjectileSizeUp()
        {
            var entity = CreateBasePlayerEntity();
            var component = entity.GetComponent<ShootComponent>();
            _powerUpFactory.GenerateProjectileSizeUpPowerUp().Obtain(entity);
            Assert.AreEqual(ProjectileSize + ProjectileSizePowerUp, component.ProjectileSize);
        }
    }
}