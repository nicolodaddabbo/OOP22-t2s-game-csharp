namespace T2SGameInput
{
    /// <summary>
    /// This functional interface represent a game Command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute the command.
        /// </summary>
        /// <param name="entity">the entity to execute the command on</param>
        void execute(IEntity entity);
    }
}