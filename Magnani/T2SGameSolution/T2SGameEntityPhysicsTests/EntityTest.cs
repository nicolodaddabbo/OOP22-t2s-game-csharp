namespace T2SGameEntityPhysicsTests
{

    [TestClass]
    public class EntityTest
    {

        private IEntity BaseEntity()
        {
            return new Entity(new Vector2D(0, 0), EntityType.Player);
        }

        [TestMethod]
        public void TestGetComponentIsPresentAndReturnsExpectedComponent()
        {
            var entity = BaseEntity();
            entity.AddComponent(new PhysicsComponent(0));
            var componentNullable = entity.GetComponent<PhysicsComponent>();
            Assert.IsTrue(componentNullable != null);
            Assert.IsTrue(componentNullable is PhysicsComponent);
        }

        [TestMethod]
        public void TestGetComponentIsNotPresent()
        {
            var entity = BaseEntity();
            entity.AddComponent(new PhysicsComponent(0));
            var componentNullable = entity.GetComponent<CollisionComponent>();
            Assert.IsFalse(componentNullable != null);
        }

    }

}