// VRSetup.cs

// Need to add the XR Interaction Toolkit package

/*
using UnityEngine;
using UnityEngine.XR.Management;

public class VRSetup : MonoBehaviour
{
    void Start()
    {
        XRGeneralSettings.Instance.Manager.InitializeLoaderSync();
        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Initializing XR failed.");
        }
        else
        {
            XRGeneralSettings.Instance.Manager.StartSubsystems();
            Debug.Log("XR Initialized.");
        }
    }

    void OnDisable()
    {
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
    }
} */