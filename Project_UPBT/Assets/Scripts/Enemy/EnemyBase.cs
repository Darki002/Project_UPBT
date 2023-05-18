using UnityEngine;
using UnityEngine.Events;
using UPBT.managers;

namespace UPBT.Enemy
{
    public class EnemyBase : MonoBehaviour
    {
        public int FightPosition => fightPosition;

        private int fightPosition;
        
        private void Start()
        {
            if (ManagerCollection.FightManager is not null)
            {
                fightPosition = ManagerCollection.FightManager.AddEnemyToFight(this);
                Debug.Log(fightPosition);
            }

            PositionEnemyBasedOnFightPosition();
        }

        public UnityEvent<int>? receiveDamage;

        public void DealDamage(int amount) => receiveDamage?.Invoke(amount);

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
