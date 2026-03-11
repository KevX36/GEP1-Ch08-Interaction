using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class GemBox : MonoBehaviour,IInteractable
{
    
    [SerializeField] private PlayerInteractionController PIC;
    [SerializeField] private UIManager uiManager;
    
    private void Start()
    {
        PIC = ServiceHub.Instance.Player.GetComponent<PlayerInteractionController>();
        uiManager = ServiceHub.Instance.UIManager;
    }
    
    public void Interact()
    {
        
        string message;
        int gemsDropedOff = 0;
        Debug.Log("interacted");
        while(PIC.Gems > 0)
        {
            PIC.Gems--;
            gemsDropedOff++;
        }
        if(gemsDropedOff > 0)
        {
            message = ($"I put {gemsDropedOff} gems in the box");
        }
        else
        {
            message = ($"I don't have any games to put in here");
        }
            uiManager.DisplayMessage(message);
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
