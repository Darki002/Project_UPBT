using System.Collections.Generic;
using UnityEngine;
using UPBT.Enemy;

namespace UPBT.managers
{
    public class FightManager : MonoBehaviour
    {
        private readonly List<EnemyBase> enemies = new List<EnemyBase>();

        private void Awake()
        {
            ManagerCollection.RegisterOrGetDestroyed(this);
        }

        public void AddEnemyToFight(EnemyBase enemy)
        {
            enemies.Add(enemy);
        }

        public EnemyBase? GetEnemyOrNull(int i)
        {
            if (i > enemies.Count)
            {
                return null;
            }
            return enemies[i];
        }
    }
}