using System;
using Unity_LegacyInputManager;
using UnityEngine;

namespace Unity_Interactable
{
    public class Interactor : MonoBehaviour
    {
        public string interactionControlName = "Interactable/Interact";
        public float maxInteractionDistance = 5f;
        public GameObject interactableUIElement;
        
        private void Update() {
            this.interactableUIElement.SetActive(false); // TODO check if unnecessary calls lead to performance issues
            
            if (!Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit, this.maxInteractionDistance)) return;
            if (!hit.collider.gameObject.CompareTag("Interactable")) return;
            
            // Display UI
            if (this.interactableUIElement) {
                this.interactableUIElement.SetActive(true); // TODO set text
            }
            
            // Run interaction events
            if (!ControlsManager.getKey(this.interactionControlName)) {
                Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();

                if (interactable != null) {
                    // TODO do interaction
                }
            }
        }
    }
}