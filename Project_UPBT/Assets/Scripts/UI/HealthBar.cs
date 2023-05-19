using UnityEngine;
using UnityEngine.UI;

namespace UPBT.UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Image healthBar = null!;
        private Camera cam = null!;

        private void Start()
        {
            cam = Camera.main!;
        }

        private void Update()
        {
            transform.rotation = Quaternion.LookRotation(transform.position - cam.transform.position);
        }

        public void ChangeHealthBar(float currentHealth, float maxHealth)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}
