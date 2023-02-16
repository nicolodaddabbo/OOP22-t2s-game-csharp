namespace T2SGameSolution.codeForTestPurposes;

public interface IEntity
{

    /// <typeparam name="T">Type of the requested component.</typeparam>
    /// <returns>The specified component if present, otherwise returns null.</returns>
    T GetComponent<T>() where T : IComponent;

    /// <summary>
    /// This method is used to notify the components of the entity.
    /// </summary>
    /// <param name="message">The message to send.</param>
    /// <typeparam name="T">The type of the receiver.</typeparam>
    /// <typeparam name="S">The type of the message.</typeparam>
    void NotifyComponent<T, S>(IMessageFunc<S> message) where T : IComponent;
}
