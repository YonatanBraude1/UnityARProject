using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;


public class Subtitles : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public TMP_Text subtitle;
    public GameObject quiz;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subtitle.text = "";
        quiz.SetActive(false);
        startsub();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startsub()
    {
        StartCoroutine(titlesub());
    }



    IEnumerator titlesub()
    {
        subtitle.text = "Degania Bet was founded in 1920 near the Sea of Galilee and the Jordan River.";
        image1.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        image1.SetActive(false);

        subtitle.text = "It was established as a pioneering and cooperative kibbutz, based on shared work and community values.";
        image2.SetActive(true);
        yield return new WaitForSecondsRealtime(6);
        image2.SetActive(false);

        subtitle.text = "Over the years, it developed strong agricultural and industrial foundations, while preserving its social spirit and commitment to Hebrew labor.";
        image3.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        image3.SetActive(false);

        subtitle.text = "The kibbutz members played an important role in shaping Israeli society and defending the settlement during the British Mandate and the early years of the state.";
        image4.SetActive(true);
        yield return new WaitForSecondsRealtime(8);
        image4.SetActive(false);

        subtitle.text = "The dining hall served as a central social and cultural hub, where people gathered not just to eat, but to celebrate, share news, and spend time together.";
        image5.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        image5.SetActive(false);

        quiz.SetActive(true);
    }


}