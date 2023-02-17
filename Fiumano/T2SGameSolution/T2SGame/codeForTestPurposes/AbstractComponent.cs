namespace T2SGame
{   ///ONLY FOR TESTING PURPOSES NOT TO BE INTENDED AS MY (Fiumanò) PART
    public abstract class AbstractComponent : IComponent
    {
        public IEntity? Entity { get; set; }

        public abstract void Receive<T>(IMessageFunc<T> message);

        public abstract void Update();
    }
}