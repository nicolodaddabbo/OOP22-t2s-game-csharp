namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This class represents the physics of the entity.
    /// </summary>
    public class PhysicsComponent : AbstractComponent
    {

        private const double CONVERSION = 2;

        /// <summary>
        /// The speed of the entity.
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// The current velocity of the entity.
        /// </summary>
        public Vector2D Velocity { get; set; }

        /// <param name="speed">The speed of the entity.</param>
        public PhysicsComponent(double speed)
        {
            Speed = speed;
            Velocity = new Vector2D(0, 0);
        }

        /// <inheritdoc />
        public override void Update()
        {
            Entity.Position = Entity.Position.Sum(Velocity.Mul(GetConvertedSpeed()));
            Entity.NotifyComponent<CollisionComponent, Vector2D>(() => Entity.Position);
        }

        /// <inheritdoc />
        public override void Receive<T>(IMessageFunc<T> message)
        {
            if(message() is Directions dir){
                ReceiveDirection(dir);
            }
        }

        private void ReceiveDirection(Directions direction)
        {
            switch (direction)
            {
                case Directions.Up:
                    Velocity = new Vector2D(0, -1);
                    break;
                case Directions.Down:
                    Velocity = new Vector2D(0, 1);
                    break;
                case Directions.Left:
                    Velocity = new Vector2D(-1, 0);
                    break;
                case Directions.Right:
                    Velocity = new Vector2D(1, 0);
                    break;
                default:
                    Velocity = new Vector2D(0, 0);
                    break;
            }
        }

        /// <returns>The converted speed of the entity.</returns>
        public double GetConvertedSpeed()
        {
            return CONVERSION * Speed;
        }

    }
}