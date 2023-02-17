namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This class represents the collsion of the entity.
    /// </summary>
    public class CollisionComponent : AbstractComponent
    {

        /// <summary>
        /// The shape of the collision.
        /// </summary>
        public Shape Shape { get; }

        /// <summary>
        /// True if the collision is rigid, false otherwise.
        /// </summary>
        public bool IsRigid { get; }

        private List<EntityType> _types;

        /// <param name="shape">The shape of the collision.</param>
        /// <param name="isRigid">If true, the collision is rigid and cant be passed through.
        ///                       Otherwise not.</param>
        /// <param name="types">The types of entity that the collision collides with.</param>
        public CollisionComponent(Shape shape, bool isRigid, List<EntityType> types)
        {
            Shape = shape;
            IsRigid = isRigid;
            _types = types;
        }

        // Disable "nullable reference types" warning because null values returned by
        // GetComponent() are being checked so there can't be a null reference.
        #pragma warning disable CS8602 // Dereference of a possibly null reference.
        /// <inheritdoc />
        public override void Update()
        {
            Entity.World?.Entities
                .Where(e => _types.Contains(e.Type))
                .Select(e => e.GetComponent<CollisionComponent>())
                .Where(c => c != null)
                .Where(c => Shape.IsColliding(c.Shape))
                .ToList()
                .ForEach(c =>
                {
                    if (IsRigid || c.IsRigid)
                    {
                        KnockBack();
                    }
                });
        }

        /// <inheritdoc />
        public override void Receive<T>(MessageFunc<T> message)
        {
            if (message() is Vector2D pos)
            {
                ReceiveFromPhysicsComponent(pos);
            }
        }

        private void ReceiveFromPhysicsComponent(Vector2D pos)
        {
            Shape.Center = pos;
        }

        private void KnockBack()
        {
            var phycmp = Entity.GetComponent<PhysicsComponent>();
            if (phycmp != null)
            {
                Entity.Position = Entity.Position.Sub(phycmp.Velocity.Mul(phycmp.GetConvertedSpeed()));
            }
        }

    }
}