using Object = UnityEngine.Object;

namespace UPBT.managers
{
    public static class ManagerCollection
    {
        public static FightManager? FightManager { get; private set; }
        
        public static GameTimeManager? GameTimeManager { get; private set; }

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
        
        public static void RegisterOrGetDestroyed(GameTimeManager gameTimeManager)
        {
            if (GameTimeManager is null)
            {
                GameTimeManager = gameTimeManager;
            }
            else
            {
                Object.Destroy(gameTimeManager);
            }
        }
    }
}
