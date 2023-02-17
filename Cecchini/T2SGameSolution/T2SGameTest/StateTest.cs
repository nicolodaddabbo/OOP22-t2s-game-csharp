using T2SGameEntityPhysics;

namespace test;

[TestClass]
public class StateTest
{
    [TestMethod]
    public void testState()
    {
        IState? state = null;
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
        IWave? wave = null;
        Assert.IsFalse(state.IsWaveOver(wave));
        // [TODO] Kill all enemies in the wave
        // ...
        Assert.IsTrue(state.IsWaveOver(wave));
    }
}