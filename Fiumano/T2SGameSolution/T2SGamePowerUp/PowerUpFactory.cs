using System;
using System.Collections.Generic;
using T2SGameSolution.codeForTestPurposes;

namespace T2SGameSolution.T2SGamePowerUp
{
    public class PowerUpFactory : IPowerUpFactory
    {
        private const int DmgUp = 1;
        private const double ProjSpeedUp = 0.5;
        private const int ProjSizeUp = 5;
        private const double FirerateUp = 0.05;
        private const int HealthUp = 1;
        private const double SpeedUp = 0.25;

        private class PowerUp : IPowerUp
        {
            private Action<IEntity> function;
            public PowerUp(Action<IEntity> function)
            {
                this.function = function;
            }

            public void Obtain(IEntity entity)
            {
                function.Invoke(entity);
            }
        }
        
        private IPowerUp FromFunction(Action<IEntity> function)
        {
            return new PowerUp(function);
        }
   
        public IPowerUp GenerateDamageBoostPowerUp()
        {
            return FromFunction(entity =>
            {
                ShootComponent shootComponent = entity.GetComponent<ShootComponent>();
                if (shootComponent != null)
                {
                    shootComponent.ProjectileDamage += DmgUp;
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
                    shootComponent.FireRateSeconds = shootComponent.FireRateSeconds + FirerateUp;
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
                    healthComponent.Health += HealthUp;
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
                    shootComponent.ProjectileSize += ProjSizeUp;
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
                    shootComponent.ProjectileSpeed += ProjSpeedUp;
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
                    physicsComponent.Speed += SpeedUp;
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
