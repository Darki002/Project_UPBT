using UnityEngine;
using UPBT.Player.Character;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private int damage;

        [SerializeField] private Targeting targetingSystem = null!;

        public void AttackEnemy()
        {
            var target = targetingSystem.Target;
            if (target is not null)
            {
                target.DealDamage(damage);
            }
        }
    }
}