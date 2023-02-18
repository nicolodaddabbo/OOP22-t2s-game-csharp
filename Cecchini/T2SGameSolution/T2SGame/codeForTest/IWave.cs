namespace ecs
{
    public interface IWave
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return a list of Entity representing a Wave</returns>
        List<IEntity> GetEnemies();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity">entity to add in the wave</param>
        /// <returns>the wave with the new entity</returns>
        IWave AddEnemy(IEntity entity);
    }
}