namespace T2SGameInput
{
    public class Entity : IEntity
    {
        public Entity()
        {
            MovingDirection = "";
            ShootingDirection = "";
        }

        public string MovingDirection { get; set; }
        public string ShootingDirection { get; set; }
    }
}
