namespace test;

[TestClass]
public class StateTest
{
    private WaveFactory _waveFactory = new WaveFactory();
    [TestMethod]
    public void testState()
    {
        IState state = new T2SState();
        Assert.AreEqual(0 , state.Round);
        state.IncrementRound();
        Assert.AreEqual(1 , state.Round);
        state.IncrementRound();
        Assert.AreEqual(2 , state.Round);
        state.IncrementRound();
        Assert.AreEqual(3 , state.Round);
        state.IncrementRound();
        Assert.AreEqual(4 , state.Round);
        // Testing isWaveOver logics
        IWave wave = _waveFactory.CreateBasicWave(1);
        Assert.IsFalse(state.IsWaveOver(wave));
        wave.GetEnemies().Clear();
        Assert.IsTrue(state.IsWaveOver(wave));
    }
}