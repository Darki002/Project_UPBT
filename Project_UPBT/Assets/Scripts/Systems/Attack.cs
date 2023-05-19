using System.Collections;
using UnityEngine;
using UPBT.Player.Character;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;
        
        [SerializeField] private int damage;

        [SerializeField] private Targeting targetingSystem = null!;

        private bool isAttacking;

        public void AttackEnemy()
        {
            if (isAttacking)
            {
                return;
            }
            
            var target = targetingSystem.Target;
            if (target is not null)
            {
                isAttacking = true;
                target.DealDamage(damage);
                StartCoroutine(PlayAttackAnimation());
            }
            else
            {
                targetingSystem.SetNewTarget();
            }
        }

        private IEnumerator PlayAttackAnimation()
        {
            var param = Animator.StringToHash("Attack");
            animator.SetTrigger(param);
            yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length + animator.GetCurrentAnimatorStateInfo(0).normalizedTime - 1);
            isAttacking = false;
        }
    }
}