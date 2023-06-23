using UnityEngine;
using UPBT.Systems;

namespace UPBT.Scenes.Fight.Enemy
{
    public class EnemyCharacter : MonoBehaviour, IFightParticipantCharacter
    {
        private Health health;
        
        public void DealDamage(int amount)
        {
            health.Reduce(amount);
        }
    }
}
