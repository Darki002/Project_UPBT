using UnityEngine;
using UPBT.managers;

namespace UPBT.Player.Character
{
    public class Targeting : MonoBehaviour
    {
        // ReSharper disable once Unity.NoNullPropagation
        public IFightParticipant? Target => ManagerCollection.FightManager?.GetEnemyOrNull(targetPosition);

        private TargetType targetType;
        private int targetPosition;
        
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
