using System.Threading.Tasks;
using UnityEngine;

namespace UPBT.Systems
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private Animator animator = null!;
        [SerializeField] private int health;

        public void DealDamage(int amount)
        {
            var animParam = Animator.StringToHash("GetHit");
            animator.SetTrigger(animParam);
            
            health = Mathf.Max(health - amount, 0);
            if (health <= 0)
            {
                GetDefeated();
            }
        }

        public void DieAnimationFinished()
        {
            Task.Delay(100).Wait();
            Destroy(gameObject);
        }
        
        private void GetDefeated()
        {
            var animParam = Animator.StringToHash("DieAfterHit");
            animator.SetBool(animParam, true);
        }
    }
}
