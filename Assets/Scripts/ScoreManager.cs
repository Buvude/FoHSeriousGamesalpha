using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int correct, incorrect,questionNumber;
    public const int TOTAL=15;
    public bool[] incorrectAnswers=new bool[15];
    public GrammerHWScript gHWS;
    public GameObject proofReading, Debugging, HistoryReader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
