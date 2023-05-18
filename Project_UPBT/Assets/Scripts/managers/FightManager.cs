using System.Collections.Generic;
using UnityEngine;
using UPBT.Enemy;

namespace UPBT.managers
{
    public class FightManager : MonoBehaviour
    {
        public int EnemyCount => enemies.Count;
        
        private readonly List<EnemyBase> enemies = new List<EnemyBase>();

        private void Awake()
        {
            ManagerCollection.RegisterOrGetDestroyed(this);
        }

        public int AddEnemyToFight(EnemyBase enemy)
        {
            enemies.Add(enemy);
            return enemies.FindIndex(e => e == enemy);
        }

        public EnemyBase? GetEnemyOrNull(int i)
        {
            if (i > enemies.Count - 1)
            {
                return null;
            }
            return enemies[i];
        }
    }
}