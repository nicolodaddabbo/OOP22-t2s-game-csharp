namespace T2STests;

[TestClass]
public class HealthComponentTest
{
    private const int StartingHealth = 3;
    private const int Damage = 1;
    private IEntity CreateBaseEntity()
    {
        return new Entity()
            .AddComponent(new HealthComponent(3));
    }

    [TestMethod]
    public void TestDamageReceived()
    {
        var entity = CreateBaseEntity();
        var component = entity.GetComponent<HealthComponent>();
        component.Health = StartingHealth;
        entity.NotifyComponent<HealthComponent, int>(() => Damage);
        Assert.AreEqual(StartingHealth - Damage, component.Health);
    }

    [TestMethod]
    public void TestDamageUnderZero()
    {
        var entity = CreateBaseEntity();
        var component = entity.GetComponent<HealthComponent>();
        component.Health = StartingHealth;
        entity.NotifyComponent<HealthComponent, int>(() => StartingHealth * 2);
        Assert.AreEqual(0, component.Health);
    }
}