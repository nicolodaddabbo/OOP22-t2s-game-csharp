using System;

namespace T2SGame
{
    ///ONLY FOR TESTING PURPOSES NOT TO BE INTENDED AS MY (Fiumanò) PART
    public class PhysicsComponent : AbstractComponent
    {
        public PhysicsComponent(double speed)
        {
            Speed = speed;
        }

        public double Speed { get; set; }
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