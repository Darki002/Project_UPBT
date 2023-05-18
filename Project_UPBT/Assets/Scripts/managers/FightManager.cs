using System;
using UnityEngine;

namespace UPBT.managers
{
    public class FightManager : MonoBehaviour
    {
        private void Awake()
        {
            ManagerCollection.RegisterOrGetDestroyed(this);
        }
    }
}
