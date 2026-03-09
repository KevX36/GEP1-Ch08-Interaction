using UnityEngine;
using TMPro;
using System.Collections;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;

    private string currentMessage = "";
    public void DisplayMessage(string message)
    {


        messageText.SetText(message);


        currentMessage = messageText.ToString();
        //StartCoroutine(messageTimer());



    }

    IEnumerable messageTimer()
    {
        Debug.Log("timer started");
        yield return new WaitForSecondsRealtime(30);
        messageText.SetText("");
    }

}
