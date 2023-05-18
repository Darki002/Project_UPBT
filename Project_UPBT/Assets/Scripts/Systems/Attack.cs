using UnityEngine;
using UnityEngine.Serialization;
using UPBT.managers;
using UPBT.Player.Character;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private int damage;

        [SerializeField] private Targeting targetingSystem = null!;

        public void AttackEnemy()
        {
            var target = ManagerCollection.FightManager!.GetEnemyOrNull(targetingSystem.TargetPosition);
            if (target is not null)
            {
                target.DealDamage(damage);
            }
        }
    }
}