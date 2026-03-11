using UnityEngine;

public class PickupInteractable : MonoBehaviour,IInteractable
{

    
    [SerializeField] private PlayerInteractionController PIC;
    private void Start()
    {
        PIC = ServiceHub.Instance.Player.GetComponent<PlayerInteractionController>();
    }


    public void Interact()
    {
        Debug.Log("interacted");
        PIC.Gems++;
        Destroy(gameObject);
    }

    public void Focused()
    {
        Debug.Log("focused");
    }

    public void UnFocused()
    {
        Debug.Log("nolonger focused");
    }





}
