using UnityEngine;
using UPBT.managers;

namespace UPBT.Player.Character
{
    public class Targeting : MonoBehaviour
    {
        public IFightParticipant? Target => ManagerCollection.FightManager!.GetEnemyOrNull(targetPosition);

        [SerializeField] private TargetType targetType;
        private int targetPosition;

        public void SetNewTarget()
        {
            if (targetPosition > 0)
            {
                if (targetPosition == ManagerCollection.FightManager!.EnemyCount)
                {
                    targetPosition -= 1;
                }
            }
        }

        public void SelectEnemyToRight()
        {
            var fightManager = ManagerCollection.FightManager;
            if (fightManager is not null)
            {
                targetPosition = Mathf.Min(targetPosition + 1, fightManager.EnemyCount - 1);
            }
        }
        
        public void SelectEnemyToLeft()
        {
            targetPosition = Mathf.Max(targetPosition - 1, 0);
        }
    }

    public enum TargetType
    {
        Enemy,
        Ally,
        Self
    }
}
