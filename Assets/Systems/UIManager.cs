using UnityEngine;
using TMPro;
using System.Collections;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;
    private Coroutine messageCoroutine;

    private void Start()
    {
        
    }
    public void DisplayMessage(string message)
    {

        if(messageCoroutine != null)
        {
            StopCoroutine(messageCoroutine);
        }
        

        messageCoroutine = StartCoroutine(messageDisplayAndFade(message));



    }

    IEnumerator messageDisplayAndFade(string message)
    {
        messageText.SetText(message);
        float messageDuration = 5f;
        messageText.alpha = 1;
        float fadeoutTime = 1.5f;
        float timeElapsed = 0f;
        Color OGColor = messageText.color;

        while (timeElapsed < messageDuration)
        {
            timeElapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timeElapsed / fadeoutTime);
            messageText.alpha = alpha;

            yield return null;
        }
        Debug.Log("timer started");
        messageText.SetText("");
    }

}
