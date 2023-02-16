using System;

namespace T2SGameSolution.codeForTestPurposes
{
    public class PhysicsComponent : AbstractComponent
    {
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