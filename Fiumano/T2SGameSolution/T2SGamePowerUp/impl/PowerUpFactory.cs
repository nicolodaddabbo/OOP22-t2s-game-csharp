using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2SGamePowerUp.api;

namespace T2SGamePowerUp.impl
{
    public class PowerUpFactory : IPowerUpFactory
    {
        private static readonly int DMGUP = 1;
        private static readonly double PROJSPEEDUP = 0.5;
        private static readonly int PROJSIZEUP = 5;
        private static readonly double FIRERATEUP = 0.05;
        private static readonly int HEALTHUP = 1;
        private static readonly double SPEEDUP = 0.25;

        private IPowerUp FromFunction(Action<Entity> function) => function.Invoke();

        public IPowerUp GenerateDamageBoostPowerUp()
        {
            return FromFunction(entity =>
            {
                ShootComponent shootComponent = entity.GetComponent<ShootComponent>();
                if (shootComponent != null)
                {
                    shootComponent.SetProjectileDamage(shootComponent.GetProjectileDamage() + DMGUP);
                }
            });
        }

        public IPowerUp GenerateFireRatioPowerUp()
        {
            return this.FromFunction(entity =>
            {
                ShootComponent shootComponent = entity.GetComponent<ShootComponent>();
                if (shootComponent != null)
                {
                    shootComponent.SetFireRateSeconds(shootComponent.GetFireRateSeconds() + FIRERATEUP);
                }
            });
        }

        public IPowerUp GenerateHealthUpPowerUp()
        {
            return this.FromFunction(entity =>
            {
                HealthComponent healthComponent = entity.GetComponent<HealthComponent>();
                if (healthComponent != null)
                {
                    healthComponent.SetHealth(healthComponent.GetHealth() + HEALTHUP);
                }
            });
        }

        public IPowerUp GenerateProjectileSizeUpPowerUp()
        {
            return this.FromFunction(entity =>
            {
                ShootComponent shootComponent = entity.GetComponent<ShootComponent>();
                if (shootComponent != null)
                {
                    shootComponent.SetProjectileSize(shootComponent.GetProjectileSize() + PROJSIZEUP);
                }
            });
        }

        public IPowerUp GenerateProjectileSpeedUpPowerUp()
        {
            return this.FromFunction(entity =>
            {
                ShootComponent shootComponent = entity.GetComponent<ShootComponent>();
                if (shootComponent != null)
                {
                    shootComponent.SetProjectileSpeed(shootComponent.GetProjectileSpeed() + PROJSPEEDUP);
                }
            });
        }

        public IPowerUp GenerateSpeedUpPowerUp()
        {
            return this.FromFunction(entity =>
            {
                PhysicsComponent physicsComponent = entity.GetComponent<PhysicsComponent>();
                if (physicsComponent != null)
                {
                    physicsComponent.SetSpeed(physicsComponent.GetSpeed() + SPEEDUP);
                }
            });
        }

        public List<IPowerUp> GetObtainablePowerUpList()
        {
            return new List<IPowerUp>
            {
                this.GenerateDamageBoostPowerUp(),
                this.GenerateFireRatioPowerUp(),
                this.GenerateHealthUpPowerUp(),
                this.GenerateProjectileSizeUpPowerUp(),
                this.GenerateProjectileSpeedUpPowerUp(),
                this.GenerateSpeedUpPowerUp()
            };
        }
    }
}
