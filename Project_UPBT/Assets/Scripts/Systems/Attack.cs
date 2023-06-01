using System.Collections;
using UnityEngine;

namespace UPBT.Systems
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;

        [SerializeField] private int damage;

        private bool isAttacking;

        private ITargeting targeting = null!;

        private void Start()
        {
            targeting = gameObject.GetComponent<ITargeting>();
        }

        public void AttackEnemy()
        {
            if (isAttacking) return;

            var target = targeting.Target;
            if (target is not null)
            {
                isAttacking = true;
                target.DealDamage(damage);
                StartCoroutine(PlayAttackAnimation());
            }
        }

        private IEnumerator PlayAttackAnimation()
        {
            var param = Animator.StringToHash("Attack");
            animator.SetTrigger(param);
            yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length +
                animator.GetCurrentAnimatorStateInfo(0).normalizedTime - 1);
            isAttacking = false;
        }
    }
}