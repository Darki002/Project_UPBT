using UnityEngine;
using UPBT.managers;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private int damage;

        private int targetPosition;

        public void AttackEnemy()
        {
            Debug.Log(targetPosition);
            var target = ManagerCollection.FightManager!.GetEnemyOrNull(targetPosition);
            if (target is not null)
            {
                target.DealDamage(damage);
            }
        }

        public void SelectEnemyToRight()
        {
            var fightManager = ManagerCollection.FightManager;
            if (fightManager is not null)
            {
                targetPosition = Mathf.Min(targetPosition + 1, fightManager.EnemyCount - 1);
            }
        }
        
        public void SelectEnemyToLeft()
        {
            targetPosition = Mathf.Max(targetPosition - 1, 0);
        }
    }
}