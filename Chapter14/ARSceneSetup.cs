// ARSceneSetup.cs
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARSceneSetup : MonoBehaviour
{
    private ARSession arSession;
    private ARSessionOrigin arSessionOrigin;
    private ARPlaneManager arPlaneManager;

    void Start()
    {
        arSession = FindObjectOfType<ARSession>();
        arSessionOrigin = FindObjectOfType<ARSessionOrigin>();
        arPlaneManager = arSessionOrigin.GetComponent<ARPlaneManager>();
    }

    void Update()
    {
        if (arPlaneManager.trackables.count > 0)
        {
            Debug.Log("Planes detected.");
        }
    }
}