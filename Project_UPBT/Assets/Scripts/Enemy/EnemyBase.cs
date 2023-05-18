using UnityEngine;
using UnityEngine.Events;
using UPBT.managers;

namespace UPBT.Enemy
{
    public class EnemyBase : MonoBehaviour
    {
        private void Start()
        {
            if (ManagerCollection.FightManager is not null)
            {
                ManagerCollection.FightManager.AddEnemyToFight(this);
            }
        }

        public UnityEvent<int>? receiveDamage;

        public void DealDamage(int amount) => receiveDamage?.Invoke(amount);
    }
}
