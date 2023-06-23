using System;
using UPBT.Scenes.Fight;

namespace UPBT
{
    public interface IFightParticipant
    {
        void DealDamageTo(int amount, int characterIndex);
    }
}