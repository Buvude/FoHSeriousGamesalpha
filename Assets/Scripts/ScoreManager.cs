using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int correct, incorrect,questionNumber;
    public const int TOTAL=15;
    public bool[] accuracyProofRead=new bool[5], accuracyCoding=new bool[5], accuracyReadingComp=new bool[5]; //true is right, false is wrong
    public int assignmentsAnswered = 0;
    public Slider HWPercentage, StressMeter;
   /* public GrammerHWScript gHWS;*/
    public GameObject proofReading, Debugging, HistoryReader;//*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HWPercentage.value = assignmentsAnswered;
    }
    public void onProofReadSelect()
    {
        proofReading.SetActive(true);
        Debugging.SetActive(false);
        HistoryReader.SetActive(false);
    }
    public void onDebugCodeSelect()
    {
        proofReading.SetActive(false);
        Debugging.SetActive(true);
        HistoryReader.SetActive(false);
    }
    public void onHistoryReadingSelect()
    {
        proofReading.SetActive(false);
        Debugging.SetActive(false);
        HistoryReader.SetActive(true);
    }
}
