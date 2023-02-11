namespace T2SGameInput
{
    /// <summary>
    /// Generic finite state of an entity.
    /// </summary>
    /// <typeparam name="I">input type</typeparam>
    public class EntityState<I> : IEntityState<I>
    {
        private readonly IDictionary<I, ICommand> _moveset;
        private ICommand? _currentCommand;

        public EntityState(IDictionary<I, ICommand> moveset)
        {
            _moveset = moveset;
            _currentCommand = null;
        }

        /// <inheritdoc />
        public ICommand? GetCurrentCommand()
        {
            return _currentCommand;
        }
        /// <inheritdoc />
        public void NotifyInput(I input)
        {
            _currentCommand = _moveset.ContainsKey(input) ? _moveset[input] : null;
        }
        /// <inheritdoc />
        public void NotifyInputRelease(I input, ICommand? releaseCommandValue)
        {
            if (_currentCommand == null)
            {
                return;
            }
            _currentCommand = _moveset.ContainsKey(input) && _moveset[input].Equals(_currentCommand) ? releaseCommandValue : _currentCommand;
        }
    }
}