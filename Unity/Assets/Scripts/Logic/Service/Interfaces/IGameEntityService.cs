using System.Collections.Generic;
using Lockstep.Game;
using Lockstep.Math;

namespace Lockstep.Game {
    public interface IGameEntityService : IService {
        Enemy CreateEnemy(int prefabId, LVector3 position);
        void CreatePlayer(Player player, int prefabId, LVector3 position);
    }
}