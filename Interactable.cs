using System;
using Unity_LegacyInputManager;
using UnityEngine;

namespace Unity_Interactable
{
    public class Interactable : MonoBehaviour
    {
        public string messageFormat = "[{0}] {1}";
        public string popupMessage = "Interact";
        
        public string message => string.Format(messageFormat, ControlsManager.getKeyCode("Interaction/Interact"), popupMessage);

        // TODO list of events on interaction
        
        private void Start() {
            if (this.CompareTag("Interactable")) {
                Debug.LogError("Interactable components should only be on GameObjects tagged as 'Interactable'.");
            }
        }
    }
}