using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Plugin : MonoBehaviour
{
    public GameObject object_to_modify;

    [DllImport("Plugin")]
    private static extern bool removeShadows();


    // Start is called before the first frame update
    void Start()
    {
        object_to_modify.GetComponent<MeshRenderer>().receiveShadows = removeShadows();
    }
}
