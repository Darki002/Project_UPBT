using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace UPBT.managers
{
    public class GameTimeManager : MonoBehaviour
    {
        public readonly UnityEvent FightStarted = new UnityEvent();

        private void Awake()
        {
            ManagerCollection.RegisterOrGetDestroyed(this);
        }

        private void Start()
        {
            StartCoroutine(StartTimer());
        }

        private IEnumerator StartTimer()
        {
            yield return new WaitForSeconds(3);
            FightStarted.Invoke();
        }
    }
}