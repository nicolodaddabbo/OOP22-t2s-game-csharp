namespace ecs;

public class EntityFactory
{
    public static IEntity CreatePlayer()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Player);
    }

    public static IEntity CreateCompanion()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Companion);
    }

    public static IEntity CreateWall()
    {
        return new Entity(new Vector2D(0, 0), EntityType.Wall);
    }

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
