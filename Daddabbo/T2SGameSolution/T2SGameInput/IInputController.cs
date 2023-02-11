namespace T2SGameInput
{
    /// <summary>
    /// This interface represent an InutController that gets notified when an input 
    /// occours and asociate a Command to that given input.
    /// </summary>
    public interface IInputController
    {
        /// <summary>
        /// The queue of the commands to be executed.
        /// </summary>
        Queue<ICommand> CommandsQueue { get; }
    }
}