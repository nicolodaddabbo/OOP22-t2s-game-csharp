using System.Collections.Concurrent;
using System.Collections.Generic;

namespace T2SGameInput
{
    /// <summary>
    /// This abstract class represents an InputController with a default implementation of the method GetCommandsQueue.
    /// </summary>
    public abstract class AbstractInputController : IInputController
    {
        private readonly Queue<ICommand> _commandsQueue = new Queue<ICommand>();

        // Returns a defensive copy of the commands queue
        public Queue<ICommand> CommandsQueue => new Queue<ICommand>(_commandsQueue);

        /// <summary>
        /// Add command to the commands queue
        /// </summary>
        /// <param name="command">the command to add</param>
        protected void AddToCommandsQueue(ICommand command)
        {
            _commandsQueue.Enqueue(command);
        }
    }
}