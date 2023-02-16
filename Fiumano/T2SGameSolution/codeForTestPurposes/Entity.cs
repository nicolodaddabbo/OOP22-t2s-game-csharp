using System.Collections.Generic;
using System.Linq;

namespace T2SGameSolution.codeForTestPurposes
{
    public class Entity : IEntity
    {
        private readonly HashSet<IComponent> _components;
        private Vector2D _position;

        /// <inheritdoc />
        public HashSet<IComponent> Components
        {
            get { return new HashSet<IComponent>(_components); }
        }

        /// <inheritdoc />
        public T GetComponent<T>() where T : IComponent
        {
            return _components.OfType<T>().FirstOrDefault();
        }

        /// <inheritdoc />
        public IEntity AddComponent(IComponent component)
        {
            _components.Add(component);
            if (component is AbstractComponent)
            {
                ((AbstractComponent)component).Entity = this;
            }
            return this;
        }

        /// <inheritdoc />
        public void NotifyComponent<T, S>(IMessageFunc<S> message) where T : IComponent
        {
            GetComponent<T>()?.Receive(message);
        }
    }
}