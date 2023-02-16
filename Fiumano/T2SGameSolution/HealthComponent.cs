using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2SGameSolution.codeForTestPurposes;

namespace T2SGameSolution
{
    public class HealthComponent : AbstractComponent
    {
        public int Health { get; set; }

        public override void Receive<T>(IMessageFunc<T> message)
        {
            if(message() is int damage){
                Health -= damage;
                    if(Health < 0)
                        Health = 0;
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}