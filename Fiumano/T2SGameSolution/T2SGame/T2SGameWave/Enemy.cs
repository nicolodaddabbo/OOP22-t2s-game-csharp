namespace T2SGame
{
    /// <summary>
    /// Basic enum representing the type of enemy
    /// </summary>
    public enum Enemy : byte
    {
        Base,
        Gaussian,
        Wild,
        Boss
    }

    /// <summary>
    /// extension method for Enum Enemy
    /// </summary>
    public static class EnemyExtension
    {
        public static IEntity CreateEnemyFromEnumType(this Enemy enemy)
        {
            switch (enemy)
            {
                case Enemy.Base:
                    return EntityFactory.CreateBaseEnemy();
                case Enemy.Gaussian:
                    return EntityFactory.CreateGaussianEnemy();
                case Enemy.Wild:
                    return EntityFactory.CreateWildEnemy();
                case Enemy.Boss:
                    return EntityFactory.CreateBossEnemy();
                default:
                    return EntityFactory.CreateBaseEnemy();
            }
        }
    }
}