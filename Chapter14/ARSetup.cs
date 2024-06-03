// ARSetup.cs
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARSetup : MonoBehaviour
{
    private ARSession arSession;
    private ARSessionOrigin arSessionOrigin;

    void Start()
    {
        arSession = GetComponent<ARSession>();
        arSessionOrigin = GetComponent<ARSessionOrigin>();

        if (ARSession.state == ARSessionState.None)
        {
            arSession.enabled = true;
        }
    }
}