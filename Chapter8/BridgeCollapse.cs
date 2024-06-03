// BridgeCollapse.cs
using UnityEngine;

public class BridgeCollapse : MonoBehaviour
{
    public float maxWeight = 500f;
    public float collapseSpeed = 2f;
    public Animator bridgeAnimator;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Get the total weight of the player and any carried objects
            float totalWeight = other.GetComponent<Rigidbody>().mass + other.GetComponent<PlayerInventory>().totalWeight;

            // If the total weight exceeds the bridge's capacity, 
            //start the collapse
            if (totalWeight > maxWeight)
            {
                bridgeAnimator.SetTrigger("Collapse");
            }
        }
    }

    private void Update()
    {
        // Gradually lower the bridge as it collapses
        transform.Translate(Vector3.down * collapseSpeed * Time.deltaTime);
    }
}