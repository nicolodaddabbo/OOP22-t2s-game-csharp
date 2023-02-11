namespace T2SGameInput
{
    /// <summary>
    /// Entity's Input Component
    /// NOTE: in the original project this class extended an abstract class developed
    /// by my collegues, and it was usless for this task.
    /// </summary>
    public class InputComponent
    {

        public InputComponent(IInputController inputController, IEntity currentEntity)
        {
            InputController = inputController;
            CurrentEntity = currentEntity;
        }
        
        public IInputController InputController { get; }
        public IEntity CurrentEntity { get; }

        // This method was present in the original project, 
        // but it would require work made by my colleagues.
        //
        // public override void Receive<T>(Message<T> message)
        // {
        //     // An input component doesn't need to receive messages
        // }

        public void Update()
        {
            foreach (var c in InputController.CommandsQueue)
            {
                c.Execute(CurrentEntity);
            }
        }
    }
}