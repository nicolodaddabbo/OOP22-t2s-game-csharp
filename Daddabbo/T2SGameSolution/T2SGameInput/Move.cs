namespace T2SGameInput
{
    /// <summary>
    /// This class is used to handle all kind of move related commands 
    /// which differs only in the direction of the movement.
    /// </summary>
    public class Move : ICommand
    {
        private readonly Directions _direction;

        public Move(Directions direction)
        {
            _direction = direction;
        }

        /// <inheritdoc />
        public void Execute(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}