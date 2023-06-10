using System;
using UnityEngine;
using UnityEngine.Events;

namespace UPBT.Player
{
    public class PlayerCharacterBase : MonoBehaviour, IFightParticipant
    {
        public int FightPosition { get; set; }
        
        public event Action<IFightParticipant>? OnDefeat;
        
        public UnityEvent<int> damageReceived = new UnityEvent<int>();
        
        public void DealDamage(int amount) => damageReceived.Invoke(amount);
    }
}