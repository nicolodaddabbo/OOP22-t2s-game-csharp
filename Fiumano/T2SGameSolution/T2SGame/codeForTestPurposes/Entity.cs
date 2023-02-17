using System.Collections.Generic;
using System.Linq;

namespace T2SGame
{
    ///ONLY FOR TESTING PURPOSES NOT TO BE INTENDED AS MY (Fiumanò) PART
    public class Entity : IEntity
    {
        private readonly HashSet<IComponent> _components = new HashSet<IComponent>();

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