namespace T2SGameInputTests
{
    [TestClass]
    public class InputTest
    {
        private const int MoveUpCode = 87;
        private const int ShootUpCode = 38;
        private readonly IEntity _entity = new Entity();
        private readonly KeyboardInputController _keyboardInputController = new KeyboardInputController();
        private readonly InputComponent _inputComponent;

        public InputTest()
        {
            _inputComponent = new InputComponent(_keyboardInputController, _entity);
        }

        [TestMethod]
        public void MoveTest()
        {
            Assert.AreEqual(_entity.MovingDirection, "");
            _keyboardInputController.NotifyKeyPressed(MoveUpCode);
            _inputComponent.Update();
            Assert.AreEqual(Directions.Up.ToString(), _entity.MovingDirection);
            _keyboardInputController.NotifyKeyReleased(0);
            Assert.AreEqual(Directions.Up.ToString(), _entity.MovingDirection);
            _keyboardInputController.NotifyKeyReleased(MoveUpCode);
            _inputComponent.Update();
            Assert.AreEqual(Directions.Stay.ToString(), _entity.MovingDirection);
        }

        [TestMethod]
        public void ShootTest()
        {
            Assert.AreEqual(_entity.ShootingDirection, "");
            _keyboardInputController.NotifyKeyPressed(ShootUpCode);
            _inputComponent.Update();
            Assert.AreEqual(Directions.Up.ToString(), _entity.ShootingDirection);
        }
    }
}
