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
            thoughtsTXT.text = "This is my proofreading, I need to find all the spelling mistakes/typos and fix them before submitting the sentence.";
            StartCoroutine("HWFade", 5f);
        }
    }

    IEnumerator HWFade(float seconds)
    {
        thoughtsPanel.SetActive(true);
        yield return new WaitForSeconds(seconds);
        thoughtsPanel.SetActive(false);
    }
}
