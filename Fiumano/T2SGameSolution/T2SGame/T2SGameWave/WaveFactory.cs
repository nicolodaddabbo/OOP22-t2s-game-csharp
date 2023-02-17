using System;
using System.Collections.Generic;
using System.Linq;

namespace T2SGame
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

        /// <inheritdoc />
        private IWave CreateWaveFromEnemies(List<IEntity> enemies)
        {
            return new Wave(enemies);
        }

        /// <inheritdoc />
        public IWave CreateBasicWave(int round)
        {
            return CreateWaveFromEnemies(Enumerable.Range(0, round / 2)
                .Select(en => Enemy.BASE.CreateEnemyFromEnumType())
                .ToList());
        }

        /// <inheritdoc />
        public IWave CreateRandomWave(int round)
        {
            return CreateWaveFromEnemies(Enumerable.Range(0, round / 2)
                .Select(en => RandomEnemy().CreateEnemyFromEnumType())
                .ToList());
        }

        /// <inheritdoc />
        public IWave CreateBossWave(int round)
        {
            return CreateRandomWave(round / 2).AddEnemy(Enemy.BOSS.CreateEnemyFromEnumType());
        }

        /// disabled warning CS8605 "Unboxing a possibly null value" the value 
        /// unboxed by .GetValue wont ever be null because it's unboxed from an Enum.
        #pragma warning disable CS8605
        private Enemy RandomEnemy()
        {
            Random random = new Random();
            return (Enemy)Enum.GetValues(typeof(Enemy)).GetValue(random.Next(Enum.GetNames(typeof(Enemy)).Length - 1));
        }
    }
}
