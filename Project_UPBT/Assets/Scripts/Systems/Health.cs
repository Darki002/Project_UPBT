using UnityEngine;

namespace UPBT.Systems
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int health;

        public void DealDamage(int amount)
        {
            health = Mathf.Max(health - amount, 0);
            if (health <= 0)
            {
                GetDefeated();
            }
        }

        private void GetDefeated()
        {
            Destroy(gameObject);
        }
    }
}
