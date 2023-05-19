using System.Collections;
using UnityEngine;

namespace UPBT.Systems
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;
        [SerializeField] private int health;

        public void DealDamage(int amount)
        {
            health = Mathf.Max(health - amount, 0);

            if (health <= 0)
            {
                StartCoroutine(PlayDieAnimation());
            }
            else
            {
                var animParam = Animator.StringToHash("GetHit");
                animator.SetTrigger(animParam);
            }
        }

        private IEnumerator PlayDieAnimation()
        {
            var animParam = Animator.StringToHash("Die");
            animator.SetBool(animParam, true);
            yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length + animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
            Destroy(gameObject);
        }
    }
}
