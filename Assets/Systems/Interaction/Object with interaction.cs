using UnityEngine;

public class Objectwithinteraction : MonoBehaviour,IInteractable
{




    public void Interact()
    {
        Debug.Log("interacted");
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
