using System.Collections;
using UnityEngine;
using UnityEngine.VR;

public class RuntimeCardboardLoader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadDevice("cardboard"));
    }

    IEnumerator LoadDevice(string newDevice)
    {
        VRSettings.LoadDeviceByName(newDevice);
        yield return null;
        VRSettings.enabled = true;
    }
}