using System.Collections.Generic;
using UnityEngine;

namespace UPBT.managers
{
    public class FightManager : MonoBehaviour
    {
        public int EnemyCount => enemies.Count;

        private readonly Queue<IFightParticipant> fightQueue = new Queue<IFightParticipant>();

        private readonly List<IFightParticipant> enemies = new List<IFightParticipant>();

        private readonly List<IFightParticipant> playerCharacters = new List<IFightParticipant>();

        private void Awake()
        {
            ManagerCollection.RegisterOrGetDestroyed(this);
        }

        public int AddPlayerCharacterToFight(IFightParticipant playerCharacter)
        {
            // queue
            playerCharacters.Add(playerCharacter);
            playerCharacter.OnDefeat += EnemyGotDefeated;
            return playerCharacters.FindIndex(e => e == playerCharacter);
        }

        public int AddEnemyToFight(IFightParticipant enemy)
        {
            // queue
            enemies.Add(enemy);
            enemy.OnDefeat += EnemyGotDefeated;
            return enemies.FindIndex(e => e == enemy);
        }

        public IFightParticipant? GetEnemyOrNull(int i)
        {
            if (i > enemies.Count - 1)
            {
                return null;
            }

            return enemies[i];
        }

        private void EnemyGotDefeated(IFightParticipant enemyBase)
        {
            enemies.Remove(enemyBase);

            for (var enemy = 0; enemy < enemies.Count; enemy++)
            {
                enemies[enemy].FightPosition = enemy;
            }
        }
    }
}