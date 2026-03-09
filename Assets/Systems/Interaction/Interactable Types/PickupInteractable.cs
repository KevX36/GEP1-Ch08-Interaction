using UnityEngine;

public class PickupInteractable : MonoBehaviour,IInteractable
{
    public string message;




    public void Interact()
    {
        Debug.Log("interacted");
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
