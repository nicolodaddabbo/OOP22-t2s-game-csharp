namespace T2SGame
{
    /// <summary>
    /// Basic enum representing the type of enemy
    /// </summary>
    public enum Enemy : byte
    {
        BASE,
        GAUSSIAN,
        WILD,
        BOSS
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
                case Enemy.BASE:
                    return EntityFactory.CreateBaseEnemy();
                case Enemy.GAUSSIAN:
                    return EntityFactory.CreateGaussianEnemy();
                case Enemy.WILD:
                    return EntityFactory.CreateWildEnemy();
                case Enemy.BOSS:
                    return EntityFactory.CreateBossEnemy();
                default:
                    return EntityFactory.CreateBaseEnemy();
            }
        }
    }
}