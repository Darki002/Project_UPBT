using System.Collections.Generic;
using UnityEngine;
using UPBT.Player;

namespace UPBT.Scenes.Fight.Enemy
{
    public class EnemyManager : MonoBehaviour, IFightParticipant
    {
        private List<EnemyCharacter> enemies = new List<EnemyCharacter>();
        
        private PlayerCharacter? target;
        
        public void DealDamageTo(int amount, int characterIndex)
        {
            enemies[characterIndex].DealDamage(amount);
        }
    }
}