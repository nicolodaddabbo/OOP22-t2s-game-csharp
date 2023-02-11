namespace T2SGameInput
{
    /// <summary>
    /// Entity was not in my section of the project, I implemented a simple version
    /// of it just for demonstration purposes.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Direction of the enity's movement
        /// </summary>
        string MovingDirection { get; set; }
        /// <summary>
        /// Entity's shooting direction
        /// </summary>
        string ShootingDirection { get; set; }
    }
}