using UnityEngine;

public class PlaceObject : MonoBehaviour
{

    public GameObject avatar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeobj()
    {
        Instantiate(avatar);
    }
}
