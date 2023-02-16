using System;

namespace T2SGameSolution.codeForTestPurposes
{
    public class ShootComponent : AbstractComponent
    {
        public double FireRateSeconds { get; set; }
        public double ProjectileSpeed { get; set; }
        public int ProjectileDamage { get; set; }
        public double ProjectileSize { get; set; }

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