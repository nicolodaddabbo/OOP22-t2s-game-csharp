namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This interface models a message container.
    /// </summary>
    /// <typeparam name="T">The type of message.</typeparam>
    /// <returns>The contained message.</returns>
    public delegate T MessageFunc<T>();
}