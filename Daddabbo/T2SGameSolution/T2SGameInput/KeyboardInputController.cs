namespace T2SGameInput
{
    /// <summary>
    /// Input controller with a keyboard as input source.
    /// </summary>
    public class KeyboardInputController : AbstractInputController
    {
        private const int MoveUpCode = 87;
        private const int MoveRightCode = 68;
        private const int MoveDownCode = 83;
        private const int MoveLeftCode = 65;
        private const int ShootUpCode = 38;
        private const int ShootRightCode = 39;
        private const int ShootDownCode = 40;
        private const int ShootLeftCode = 37;
        private static readonly IDictionary<int, ICommand> WalkMoveset = new Dictionary<int, ICommand>()
        {
            [MoveUpCode] = new Move(Directions.Up),
            [MoveRightCode] = new Move(Directions.Right),
            [MoveDownCode] = new Move(Directions.Down),
            [MoveLeftCode] = new Move(Directions.Left)
        };
        private static readonly IDictionary<int, ICommand> ShootMovest = new Dictionary<int, ICommand>()
        {
            [ShootUpCode] = new Shoot(Directions.Up),
            [ShootRightCode] = new Shoot(Directions.Right),
            [ShootDownCode] = new Shoot(Directions.Down),
            [ShootLeftCode] = new Shoot(Directions.Left)
        };
        private readonly IEntityState<int> _moveState = new EntityState<int>(WalkMoveset);
        private readonly IEntityState<int> _shootState = new EntityState<int>(ShootMovest);
        private readonly List<IEntityState<int>> _states = new List<IEntityState<int>>();

        public KeyboardInputController()
        {
            _states.Add(_moveState);
            _states.Add(_shootState);
            AddToCommandsQueue();
        }

        public void NotifyKeyPressed(int keyCode)
        {
            _states.ForEach(s => s.NotifyInput(keyCode));
            AddToCommandsQueue();
        }

        public void NotifyKeyReleased(int keyCode)
        {
            _moveState.NotifyInputRelease(keyCode, new Move(Directions.STAY));
            _shootState.NotifyInputRelease(keyCode, null);
            AddToCommandsQueue();
        }

        private void AddToCommandsQueue()
        {
            _states.Select(s => s.GetCurrentCommand())
                    .ToList().ForEach(s =>
                    {
                        if (s != null)
                        {
                            base.AddToCommandsQueue(s);
                        }
                    });
        }

    }
}