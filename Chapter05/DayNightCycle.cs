// DayNightCycle.cs
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight;
    public float dayLength;
    private float timeCounter = 0;

    void Update()
    {
        timeCounter += Time.deltaTime / dayLength;

        // Change light intensity and color based on timeCounter
        directionalLight.intensity = Mathf.Lerp(0.1f, 1,  
            Mathf.Abs(Mathf.Cos(timeCounter * Mathf.PI * 
                                2)));
        directionalLight.color = Color.Lerp(new Color(0.3f, 
                0.4f, 0.6f), Color.white, 
            directionalLight.intensity);
    }
}