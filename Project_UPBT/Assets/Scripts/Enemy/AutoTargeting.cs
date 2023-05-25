using UnityEngine;
using UPBT.managers;

namespace UPBT.Enemy
{
    public class AutoTargeting : MonoBehaviour, ITargeting
    {
        public IFightParticipant? Target => ManagerCollection.FightManager!.GetEnemyOrNull(GetRandomTargetPosition());

        private int GetRandomTargetPosition() => Random.Range(0, ManagerCollection.FightManager!.EnemyCount);
    }
}
