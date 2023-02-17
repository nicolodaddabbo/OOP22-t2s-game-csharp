namespace T2STests;
/// disabled warning CS8602 Dereference of a possibly null reference, 
/// the value will never be null because is setted before the dereference 
#pragma warning disable CS8602
[TestClass]
public class HealthComponentTest
{
    private const int StartingHealth = 3;
    private const int Damage = 1;
    private IEntity CreateBaseEntity()
    {
        return new Entity()
            .AddComponent(new HealthComponent(StartingHealth));
    }

    [TestMethod]
    public void TestDamageReceived()
    {
        var entity = CreateBaseEntity();
        var component = entity.GetComponent<HealthComponent>();
        entity.NotifyComponent<HealthComponent, int>(() => Damage);
        Assert.AreEqual(StartingHealth - Damage, component.Health);
    }

    [TestMethod]
    public void TestDamageUnderZero()
    {
        var entity = CreateBaseEntity();
        var component = entity.GetComponent<HealthComponent>();
        entity.NotifyComponent<HealthComponent, int>(() => StartingHealth * 2);
        Assert.AreEqual(0, component.Health);
    }
}