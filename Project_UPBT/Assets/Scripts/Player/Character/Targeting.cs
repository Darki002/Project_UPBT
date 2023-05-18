using UnityEngine;
using UPBT.managers;

namespace UPBT.Player.Character
{
    public class Targeting : MonoBehaviour
    {
        public int TargetPosition { get; private set; }
        
        public void SelectEnemyToRight()
        {
            var fightManager = ManagerCollection.FightManager;
            if (fightManager is not null)
            {
                TargetPosition = Mathf.Min(TargetPosition + 1, fightManager.EnemyCount - 1);
            }
        }
        
        public void SelectEnemyToLeft()
        {
            TargetPosition = Mathf.Max(TargetPosition - 1, 0);
        }
    }
}
