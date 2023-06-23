using UnityEngine;

namespace UPBT.Player
{
    public class PlayerCharacter : MonoBehaviour
    {
        public int Damage => baseAttack;

        [SerializeField] private int baseAttack = 10;

        public void PlayAttackAnimation()
        {
            
        }
    }
}