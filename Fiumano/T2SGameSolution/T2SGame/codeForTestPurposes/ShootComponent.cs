using System;

namespace T2SGame
{
    ///ONLY FOR TESTING PURPOSES NOT TO BE INTENDED AS MY (Fiumanò) PART
    public class ShootComponent : AbstractComponent
    {
        public double FireRateSeconds { get; set; }
        public double ProjectileSpeed { get; set; }
        public int ProjectileDamage { get; set; }
        public double ProjectileSize { get; set; }
        public ShootComponent(double fireRateSeconds, double projectileSpeed, int projectileDamage, double projectileSize)
        {
            FireRateSeconds = fireRateSeconds;
            ProjectileSpeed = projectileSpeed;
            ProjectileDamage = projectileDamage;
            ProjectileSize = projectileSize;
        }

        public override void Receive<T>(IMessageFunc<T> message)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}