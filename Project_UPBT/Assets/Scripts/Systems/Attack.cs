using UnityEngine;
using UnityEngine.InputSystem;
using UPBT.managers;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private int damage;
        
        public void AttackEnemy()
        {
            var target = ManagerCollection.FightManager!.GetEnemyOrNull(0);
            if (target is not null)
            {
                target.DealDamage(damage);
            }
        }
    }
}