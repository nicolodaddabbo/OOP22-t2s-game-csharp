namespace T2SGameEntityPhysics;

public class EntityFactory
{
    public static IEntity CreateBaseEnemy()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Enemy);
    }

    public static IEntity CreateBossEnemy()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Enemy);

    }

    public static IEntity CreateGaussianEnemy()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Enemy);

    }

    public static IEntity CreateWildEnemy()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Enemy);

    }
}
