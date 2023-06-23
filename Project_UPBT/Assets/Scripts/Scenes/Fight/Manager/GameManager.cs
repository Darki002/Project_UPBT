using System;
using UnityEngine;
using UnityEngine.Events;

namespace UPBT.Scenes.Fight.Manager
{
    public class GameManager : MonoBehaviour
    {
        [NonSerialized] public readonly UnityEvent<GameStats> OnGameStateChange = new UnityEvent<GameStats>();

        private GameStats gameStats;

        private GameStats GameStat
        {
            get => gameStats;
            set
            {
                gameStats = value;
                OnGameStateChange.Invoke(gameStats);
            }
        }

        public static GameManager? Instance { get; private set; }

        private void Awake()
        {
            GameStat = GameStats.InstantiateScene;

            if (Instance is null)
                Instance = this;
            else
                Destroy(this);
        }
    }
}