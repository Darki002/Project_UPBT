using System;

namespace UPBT
{
    public interface IFightParticipant
    {
        public int FightPosition { set; }
        
        public event Action<IFightParticipant>? OnDefeat;
        
        void DealDamage(int amount);
    }
}