using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    public PlaceIndicator placeIndicator;
    public GameObject objectToPlace;
    private GameObject newplacedObject;
    public Subtitles sub;
    public GameObject PI;
    public GameObject placebutton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickToPlace()
    {
        /**
        newplacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        sub.startsub();
        PI.SetActive(false);
        placebutton.SetActive(false);
        **/

    }
}
