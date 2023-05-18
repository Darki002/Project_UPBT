using UnityEngine;

namespace UPBT.managers
{
    public static class ManagerCollection
    {
        public static FightManager? FightManager { get; private set; }

        public static void RegisterOrGetDestroyed(FightManager fightManager)
        {
            if (FightManager is null)
            {
                FightManager = fightManager;
            }
            else
            {
                Object.Destroy(fightManager);
            }
        }
    }
}
