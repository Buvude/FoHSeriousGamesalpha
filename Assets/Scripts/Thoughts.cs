using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Thoughts : MonoBehaviour
{
    public GameObject thoughtsPanel,gameOverThoughtsPanel;
    public TextMeshProUGUI thoughtsTXT, gameOverThoughtsTXT;
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
            thoughtsTXT.text = "You have a series of sentences in front of you to proofread. Check for evident grammar and spelling errors and change them. If you make a mistake, press RESET. Once there are no errors, press SUBMIT.";
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

    public void MusicCopingStrat()
    {
        gameOverThoughtSpawn();
        gameOverThoughtsTXT.text = "PLACEHOLDER EXPLANATION ON HOW MUSIC CAN HELP WITH ADHD/FOCUS (INCLUDING GETTING RID OF AN EARWORM)";
    }

    public void FidgetCopingStrat()
    {
        gameOverThoughtSpawn();
        gameOverThoughtsTXT.text = "PLACEHOLDER EXPLANATION ON HOW FIDGETING CAN HELP WITH ADHD/FOCUS";
    }

    public void TaskSwitchCopingStrat()
    {
        gameOverThoughtSpawn();
        gameOverThoughtsTXT.text = "PLACEHOLDER EXPLANATION ON HOW SWITCHING TASKS CAN HELP WITH ADHD/FOCUS (INCLUDING GETTING RID OF AN EARWORM)";
    }

    public void ThoughtSpawn()
    {
        thoughtsPanel.SetActive(true);
    }

    public void gameOverThoughtSpawn()
    {
        gameOverThoughtsPanel.SetActive(true);
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
