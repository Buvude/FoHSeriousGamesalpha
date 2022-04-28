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
            ThoughtSpawn();
            thoughtsTXT.text = "This is my proofreading, I need to find all the spelling mistakes/typos and fix them before submitting the sentence.";
            /*StartCoroutine("HWFade", 5f);*/
        }
    }

    public void FirstTimeHistoryReadng()
    {
        if (firstTimeReadComp)
        {
            ThoughtSpawn();
            thoughtsTXT.text = "I know one of the passages I bookmarked should have the answer to this…";
            /*StartCoroutine("HWFade", 10f);*/
        }
    }

    public void FirstTimeCoding()
    {
        if (firstkTimeCode)
        {
            ThoughtSpawn();
            thoughtsTXT.text = "Programming is easy. I just need to tell the bot what to do, and make sure I do so in the right order while keeping it’s orientation in mind……";
            /*StartCoroutine("HWFade", 10f);*/
        }
    }

    public void ThoughtSpawn()
    {
        thoughtsPanel.SetActive(true);
    }

    public void ThoughtDespawn()
    {
        thoughtsPanel.SetActive(false);
    }
    /*IEnumerator HWFade(float seconds)
    {
        *//*thoughtsPanel.SetActive(true);
        yield return new WaitForSeconds(seconds);
        thoughtsPanel.SetActive(false);*//*
    }*/
}
