// LaunchProjectile.cs
using UnityEngine;
 
public class LaunchProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float launchAngle = 45f;
    public float launchForce = 10f;

    void Start()
    {
        Vector2 launchDirection = Quaternion.Euler(0, 0, launchAngle) 
                                  * Vector2.right;
        projectile.AddForce(launchDirection * launchForce, 
            ForceMode2D.Impulse);
    }
}