using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace UPBT.Systems
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;
        [SerializeField] private int maxHealth;
        [SerializeField] private UnityEvent<float, float>? onHealthStateChanged;

        private int currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public void Reduce(int amount)
        {
            currentHealth = Mathf.Max(currentHealth - amount, 0);
            onHealthStateChanged?.Invoke(currentHealth, maxHealth);
            
            if (currentHealth <= 0)
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
