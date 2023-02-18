namespace ecs;
    public interface IWaveFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="round">round in which the method is called</param>
        /// <returns></returns>
        IWave CreateBasicWave(int round);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="round">round in which the method is called</param>
        /// <returns>a wave filled with random enemies</returns>
        IWave CreateRandomWave(int round);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="round">round in which the method is called</param>
        /// <returns>a wave with a boss and some random enemies</returns>
        IWave CreateBossWave(int round);
    }
