using System;
using System.Collections.Generic;
using UnityEngine;
using UPBT.Player;
using UPBT.Scenes.Fight.Enemy;

namespace UPBT.Scenes.Fight.Player
{
    public class PlayerManager : MonoBehaviour
    {
        private EnemyManager enemyManager = null!;
        
        private List<PlayerCharacter> characters = new List<PlayerCharacter>();

        private int targetIndex;

        private void Start()
        {
            enemyManager = FindObjectOfType<EnemyManager>();
        }

        private void Attack()
        {
            enemyManager.DealDamageTo(0, targetIndex);
        }
    }
}