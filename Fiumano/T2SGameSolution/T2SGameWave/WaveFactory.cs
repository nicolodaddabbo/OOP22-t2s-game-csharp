using System.Collections.Generic;
using T2SGameSolution.codeForTestPurposes;

namespace T2SGameSolution.T2SGameWave
{
    public class WaveFactory : IWaveFactory
    {
        private class Wave : IWave
        {
            private List<IEntity> entities;
            public Wave(List<IEntity> entities)
            {
                this.entities = entities;
            }

            public IWave AddEnemy(IEntity entity)
            {
                entities.Add(entity);
                return this;
            }

            public List<IEntity> GetEnemies()
            {
                return entities;
            }
        }

        private IWave CreateWaveFromEnemies(List<IEntity> enemies)
        {
            return new Wave(enemies);
        }

        public IWave CreateBasicWave(int round)
        {
            return CreateWaveFromEnemies(Enumerable.Range(0, round)
                .Select(en => Enemy.BASE.CreateEnemyFromEnumType())
                .ToList());
        }

        public IWave CreateRandomWave(int round)
        {
            return CreateWaveFromEnemies(Enumerable.Range(0, round)
                .Select(en => RandomEnemy().CreateEnemyFromEnumType())
                .ToList());
        }

        public IWave CreateBossWave(int round)
        {
            return CreateRandomWave(round / 2).AddEnemy(Enemy.BOSS.CreateEnemyFromEnumType());
        }

        private Enemy RandomEnemy(){
            Random random = new Random();
            return (Enemy) Enum.GetValues(typeof(Enemy)).GetValue(random.Next(Enum.GetNames(typeof(Enemy)).Length - 1));
        }
    }
}
