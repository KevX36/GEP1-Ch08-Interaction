using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;

    private string currentMessage = "";
    public void DisplayMessage(string message)
    {


        messageText.SetText(message);


        currentMessage = messageText.ToString();




    }



}
