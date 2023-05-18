using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace UPBT.Systems
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] public List<KeyEventPaar> inputSubscription = new List<KeyEventPaar>();

        private void Update()
        {
            foreach (var inputSub in inputSubscription)
            {
                var key = inputSub.key;
                if (Keyboard.current[key].wasPressedThisFrame)
                {
                    inputSub.@event.Invoke();
                }
            }
        }
        
        [Serializable]
        public class KeyEventPaar
        {
            public Key key;
            public UnityEvent @event;

            public KeyEventPaar(UnityEvent @event, Key key)
            {
                this.@event = @event;
                this.key = key;
            }
        }
    }
}