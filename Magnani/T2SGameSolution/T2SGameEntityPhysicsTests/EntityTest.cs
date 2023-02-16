namespace T2SGameEntityPhysicsTests
{

    [TestClass]
    class EntityTest
    {

        private Entity BaseEntity()
        {
            return new Entity(new Vector2D(0, 0), EntityType.Player);
        }

        [TestMethod]
        void TestGetComponentIsPresentAndReturnsExpectedComponent()
        {
            Entity entity = BaseEntity();
            entity.AddComponent(new PhysicsComponent(0));
            var componentNullable = entity.GetComponent<PhysicsComponent>();
            Assert.IsTrue(componentNullable != null);
            Assert.IsTrue(componentNullable is PhysicsComponent);
        }

        [TestMethod]
        void TestGetComponentIsNotPresent()
        {
            Entity entity = BaseEntity();
            entity.AddComponent(new PhysicsComponent(0));
            var componentNullable = entity.GetComponent<PhysicsComponent>();
            Assert.IsFalse(componentNullable != null);
        }

    }
    
}