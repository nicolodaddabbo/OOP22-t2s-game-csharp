namespace T2SGameSolution.T2STests
{
    [TestClass]
    public class HealthComponentTest
    {
        private const int StartingHealth = 3;
        private const int Damage = 1;
        private IEntity CreateBaseEntity()
        {
            return new Entity()
                .AddComponent(new HealthComponent());
        }   
        [TestMethod]
        void TestDamageReceived(){
            var entity = CreateBaseEntity();
            var component = entity.GetComponent<HealthComponent>();
            component.Health = StartingHealth;
            entity.NotifyComponent<HealthComponent, int>(() => Damage);

        }
    }
}