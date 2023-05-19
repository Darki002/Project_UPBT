using UnityEngine;
using UPBT.Player.Character;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;
        
        [SerializeField] private int damage;

        [SerializeField] private Targeting targetingSystem = null!;

        public void AttackEnemy()
        {
            var target = targetingSystem.Target;
            if (target is not null)
            {
                var param = Animator.StringToHash("Attack");
                animator.SetTrigger(param);
                target.DealDamage(damage);
            }
            else
            {
                targetingSystem.SetNewTarget();
            }
        }
    }
}