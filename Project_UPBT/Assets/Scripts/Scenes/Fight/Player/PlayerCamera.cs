using UnityEngine;

namespace UPBT.Player
{
    public class PlayerCamera : MonoBehaviour
    {
        public void ChangeTarget(GameObject newTarget)
        {
            transform.rotation = Quaternion.LookRotation(newTarget.transform.position - transform.position);
        }
    }
}
