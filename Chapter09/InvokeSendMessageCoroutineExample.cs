// InvokeSendMessageCoroutineExample.cs
using UnityEngine;

public class InvokeSendMessageCoroutineExample : 
    MonoBehaviour
{
    void Start()
    {
        Invoke("DelayedAction", 2.0f); // Using Invoke
        StartCoroutine(WaitAndPerformAction(3.0f)); 
        // Using Coroutine
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessage("PerformAction"); 
            // Using SendMessage
        }
    }

    void DelayedAction()
    {
        Debug.Log("Action performed after delay.");
    }

    IEnumerator WaitAndPerformAction(float delay)
    {
        yield return new WaitForSeconds(delay); // Waiting
        Debug.Log("Coroutine action performed 
        after delay.");
    }

    void PerformAction()
    {
        Debug.Log("Action performed via SendMessage.");
    }
}