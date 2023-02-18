using System.Linq;
using ecs;

namespace T2SGame;

/// <summary>
/// This class represents a basics implementation of State's interface.
/// This class increments the round by 1.
/// </summary>
public class T2SState : IState
{
    private int _round;
    public int Round => _round;

    /// <inheritdoc />
    public void IncrementRound() => _round++;

    /// <inheritdoc />
    public bool IsOver(List<IEntity> entities) => !entities.Any();

    /// <inheritdoc />
    public bool IsWaveOver(IWave? wave) => wave == null || !wave.GetEnemies().Any();
}