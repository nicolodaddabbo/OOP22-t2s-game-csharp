namespace T2SGameInput
{
    /// <summary>
    /// This class is used to handle all kind of shooting related commands
    /// which differs only in the direction of the projectile.
    /// </summary>
    public class Shoot : ICommand
    {
        private readonly Directions _direction;

        public Shoot(Directions direction)
        {
            _direction = direction;
        }

        /// <inheritdoc />
        public void execute(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}