namespace T2SGameSolution.codeForTestPurposes
{
    public abstract class AbstractComponent : IComponent
    {
        public IEntity Entity { get; set; }

        public abstract void Receive<T>(IMessageFunc<T> message);

        public abstract void Update();
    }
}