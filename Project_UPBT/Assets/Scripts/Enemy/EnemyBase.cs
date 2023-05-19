using UnityEngine;
using UnityEngine.Events;
using UPBT.managers;

namespace UPBT.Enemy
{
    public class EnemyBase : MonoBehaviour, IFightParticipant
    {
        public int FightPosition => fightPosition;

        private int fightPosition;
        
        private void Start()
        {
            if (ManagerCollection.FightManager is not null)
            {
                fightPosition = ManagerCollection.FightManager.AddEnemyToFight(this);
            }

            PositionEnemyBasedOnFightPosition();
        }

        public UnityEvent<int>? damageReceived;

        public void DealDamage(int amount) => damageReceived?.Invoke(amount);

        private void PositionEnemyBasedOnFightPosition()
        {
            var x = 5 * (fightPosition - 1);
            var trans = transform;
            var position = trans.position;
            position = new Vector3(x,  position.y, position.z);
            trans.position = position;
        }
    }
}
