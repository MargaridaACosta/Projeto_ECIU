using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAndr : MonoBehaviour
{
    static WebCamTexture backCamera;

    void Start()
    {
        if (backCamera == null)
        backCamera = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = backCamera;

        if (!backCamera.isPlaying)
        backCamera.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
