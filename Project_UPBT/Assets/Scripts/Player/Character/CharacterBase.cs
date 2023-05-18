using UnityEngine;
using UnityEngine.InputSystem;
using UPBT.Enemy;
using UPBT.managers;

namespace UPBT.Player.Character
{
    public class CharacterBase : MonoBehaviour
    {
        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                var target = ManagerCollection.FightManager!.GetEnemyOrNull(0);
                if (target is not null)
                {
                    target.DealDamage(10);
                }
            }
        }
    }
}