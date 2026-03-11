using UnityEngine;

public class MessageInteractable : MonoBehaviour,IInteractable
{
    [SerializeField] private UIManager uiManager;
    public string message;
    private void Start()
    {
        uiManager = ServiceHub.Instance.UIManager;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Interact()
    {
        Debug.Log("interacted");
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
