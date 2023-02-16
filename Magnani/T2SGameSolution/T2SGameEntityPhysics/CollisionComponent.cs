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

        /// <inheritdoc />
        public override void Update()
        {
            KnockBack();
        }

        /// <inheritdoc />
        public override void Receive<T>(IMessageFunc<T> message)
        {
            if(message() is Vector2D pos){
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