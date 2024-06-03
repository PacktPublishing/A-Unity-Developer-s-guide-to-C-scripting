// SwipeControl.cs
sing UnityEngine;

public class SwipeControl : MonoBehaviour
{
    private Vector2 startTouchPosition, endTouchPosition;
    public float minSwipeDistance = 50f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                DetectSwipe();
            }
        }
    }

    void DetectSwipe()
    {
        if (Vector2.Distance(startTouchPosition, endTouchPosition) >= 
            minSwipeDistance)
        {
            Vector2 swipeDirection = endTouchPosition - 
                                     startTouchPosition;
            // Implement your swipe action based on swipeDirection
        }
    }
}