namespace T2SGameEntityPhysicsTests
{

    [TestClass]
    public class MessageTest
    {
        private IEntity BaseEntity()
        {
            var pos = new Vector2D(0, 0);
            return new Entity(pos, EntityType.Player)
                .AddComponent(new PhysicsComponent(1))
                .AddComponent(new CollisionComponent(
                    new Shape(pos), false, new List<EntityType>()));
        }

        [TestMethod]
        public void TestPhysicsReceiveDirection()
        {
            var entity = BaseEntity();
            entity.NotifyComponent<PhysicsComponent, Directions>(() => Directions.Up);
            var physComponent = entity.GetComponent<PhysicsComponent>();
            Assert.AreEqual(new Vector2D(0, -1), physComponent.Velocity);
        }

        [TestMethod]
        public void TestPhysicsReceiveUnwantedMessage()
        {
            var entity = BaseEntity();
            entity.NotifyComponent<PhysicsComponent, String>(() => "Go up");
            var physComponent = entity.GetComponent<PhysicsComponent>();
            Assert.AreNotEqual(new Vector2D(0, -1), physComponent.Velocity);
        }

        [TestMethod]
        public void TestCollisionReceivePosition()
        {
            var entity = BaseEntity();
            var pos = new Vector2D(5, 5);
            entity.NotifyComponent<CollisionComponent, Vector2D>(() => pos);
            var collComponent = entity.GetComponent<CollisionComponent>();
            Assert.AreEqual(pos, collComponent.Shape.Center);
        }

        [TestMethod]
        public void TestCollisionReceiveUnwantedMessage()
        {
            var entity = BaseEntity();
            var pos = new Vector2D(5, 5);
            entity.NotifyComponent<PhysicsComponent, String>(() => "Go to position 5:5");
            var collComponent = entity.GetComponent<CollisionComponent>();
            Assert.AreNotEqual(pos, collComponent.Shape.Center);
        }

        [TestMethod]
        public void TestComunicationPhysicsWithCollision()
        {
            var entity = BaseEntity();
            entity.NotifyComponent<PhysicsComponent, Directions>(() => Directions.Up);
            var physComponent = entity.GetComponent<PhysicsComponent>();
            physComponent.Update();
            var collComponent = entity.GetComponent<CollisionComponent>();
            Assert.AreEqual(entity.Position, collComponent.Shape.Center);
        }
    }

}