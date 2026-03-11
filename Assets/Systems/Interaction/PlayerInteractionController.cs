using UnityEngine;
using UnityEngine.InputSystem;




public class PlayerInteractionController : MonoBehaviour
{


    [SerializeField] private IInteractable targetInteractable;

    [SerializeField] private GameObject InteractableObject;

    public int Gems = 0;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            InteractableObject = other.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            InteractableObject = null;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            
            if(targetInteractable != null)
            {
                Debug.Log("Interacted");
                targetInteractable.Interact();
            }
            
        }
        
    }




}
