using UnityEngine;
using UPBT.managers;

namespace UPBT.Player.Character
{
    public class ManuelTargeting : MonoBehaviour, ITargeting
    {
        public IFightParticipant? Target => GetTarget();

        [SerializeField] private TargetType targetType;
        private int targetPosition;

        private IFightParticipant? GetTarget()
        {
            var target = ManagerCollection.FightManager!.GetEnemyOrNull(targetPosition);
            if (target is null)
            {
                targetPosition -= 1;
                target = ManagerCollection.FightManager!.GetEnemyOrNull(targetPosition);
            }

            return target;
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
