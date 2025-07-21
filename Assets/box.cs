using UnityEngine;

public class CameraPreview : MonoBehaviour
{
    private WebCamTexture webcamTexture;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing) // use back camera
            {
                webcamTexture = new WebCamTexture(devices[i].name);
                break;
            }
        }

        if (webcamTexture != null)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }
    }
}
