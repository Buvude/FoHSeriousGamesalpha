using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Thoughts : MonoBehaviour
{
    public GameObject thoughtsPanel;
    public TextMeshProUGUI thoughtsTXT;
    public bool firstTimeProofRead=true, firstkTimeCode=true, firstTimeReadComp=true; //TODO these booleans must only change once the first question is answered
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FirstTimeProofReading()
    {
        if (firstTimeProofRead)
        {
            StopCoroutine("HWFade");
            thoughtsTXT.text = "This is my proofreading, I need to find all the spelling mistakes/typos and fix them before submitting the sentence.";
            StartCoroutine("HWFade", 5f);
        }
    }

    public void FirstTimeHistoryReadng()
    {
        if (firstTimeReadComp)
        {
            StopCoroutine("HWFade");
            thoughtsTXT.text = "This is my history homework... I remember that one of these three paragraphs has the answer... if I can select the right one I can answer it fairly easily then";
            StartCoroutine("HWFade", 10f);
        }
    }

    public void FirstTimeCoding()
    {
        if (firstTimeReadComp)
        {
            StopCoroutine("HWFade");
            thoughtsTXT.text = "I just need to guide the little guy at the start to the end, taking the direction he is facing into account. I need to tell him all the directions then hit submit";
            StartCoroutine("HWFade", 10f);
        }
    }

    IEnumerator HWFade(float seconds)
    {
        thoughtsPanel.SetActive(true);
        yield return new WaitForSeconds(seconds);
        thoughtsPanel.SetActive(false);
    }
}
