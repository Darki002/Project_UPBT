using UnityEngine;
using UPBT.Systems;

namespace UPBT.Animations.Boxer
{
    public class Die : StateMachineBehaviour
    {
        public Health healthSystem = null!;
        
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateExit(animator, stateInfo, layerIndex);
            healthSystem.DieAnimationFinished();
        }
    }
}
