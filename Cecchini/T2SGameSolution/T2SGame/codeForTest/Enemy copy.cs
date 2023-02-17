namespace T2SGameEntityPhysics
{
    public enum Enemy{
        BASE,
        GAUSSIAN,
        WILD,
        BOSS
    }

    public static class EnemyExtension
    {
        public static IEntity CreateEnemyFromEnumType(this Enemy enemy){
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
                    return null;
            }
        }
    }
}