// AssetBundleLoader.cs
using UnityEngine;
using System.Collections;

public class AssetBundleLoader : MonoBehaviour
{
    public string bundleURL;
    public string assetName;

    void Start()
    {
        StartCoroutine(LoadAssetBundle());
    }

    IEnumerator LoadAssetBundle()
    {
        using (WWW www = new WWW(bundleURL))
        {
            yield return www;
            AssetBundle bundle = www.assetBundle;
            if (bundle != null)
            {
                Instantiate(bundle.LoadAsset(assetName));
                bundle.Unload(false);
            }
        }
    }
}