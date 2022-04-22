using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int correct, incorrect/*,questionNumber*/;
    public const int TOTAL=15;
    public bool[] accuracyProofRead=new bool[5], accuracyCoding=new bool[5], accuracyReadingComp=new bool[5], copingSkills=new bool[3]; //true is right, false is wrong
    public string[] accuracyProofReadstring = new string[5], accuracyCodingstring = new string[5], accuracyReadingCompstring = new string[5];
    public int assignmentsAnswered = 0;
    public Slider HWPercentage, StressMeter;
    public Button copingStrategy1, copingStrategy2, copingStrategy3;
    public TextMeshProUGUI copingStrat1txt, copingStrat2txt, copingStrat3txt;
    private int eLAScore = 5, CodingScore = 5, HistoryScore = 5;
   /* public GrammerHWScript gHWS;*/
    public GameObject proofReading, Coding, HistoryReader, gameOver;//*/
    public TextMeshProUGUI EnglishScoretxt, CodingScoretxt, HistoryScoretxt/*, copingscoretxt*/;
    public DistractionCenter DC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HWPercentage.value = assignmentsAnswered;
        if (HWPercentage.value == 15)
        {
            finished();
        }
    }

    public void finished()
    {
        gameOver.SetActive(true);
        for (int x = 0; x < 5; x++)
        {
            if (accuracyProofRead[x])
            {
                accuracyProofReadstring[x] = "Correct ";
            }
            else
            {
                accuracyProofReadstring[x] = "Incorrect ";
                eLAScore--;
            }
            if (accuracyCoding[x])
            {
                accuracyCodingstring[x] = "Correct ";
            }
            else
            {
                accuracyCodingstring[x] = "Incorrect ";
                CodingScore--;
            }
            if (accuracyReadingComp[x])
            {
                accuracyReadingCompstring[x] = "Correct ";
            }
            else
            {
                accuracyReadingCompstring[x] = "Incorrect ";
                HistoryScore--;
            }
        }
        for(int x = 0; x<3; x++)
        {
            if (copingSkills[x])
            {
                switch (x)
                {
                    case 0:
                        copingStrategy1.interactable = true;
                        copingStrat1txt.text = "Listening to a song all the way through to get rid of an 'earworm'";
                        break;
                    case 1:
                        copingStrategy2.interactable = true;
                        copingStrat2txt.text = "Listening to music while you work to help you concentrate";
                        break;
                    case 2:
                        copingStrategy3.interactable = true;
                        copingStrat3txt.text = "Ignoring notifications on your computer unless...";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (x)
                {
                    case 0:
                        copingStrategy1.interactable = false;
                        copingStrat1txt.text = "How to deal with an 'earworm'";
                        break;
                    case 1:
                        copingStrategy2.interactable = false;
                        copingStrat2txt.text = "A way to help someone with ADHD focus";
                        break;
                    case 2:
                        copingStrategy3.interactable = false;
                        copingStrat3txt.text = "How to deal with all the notifications";
                        break;
                    default:
                        break;
                }
            }
        }
        switch (eLAScore)
        {
            case 5:
                EnglishScoretxt.text = "Proofreading score: A+! questions in order were: \t" + accuracyProofReadstring[0] + "\t" + accuracyProofReadstring[1] + "\t" + accuracyProofReadstring[2] + "\t" + accuracyProofReadstring[3] + "\t" + accuracyProofReadstring[4] + "\t";
                break;
            case 4:
                EnglishScoretxt.text = "Proofreading score: B+! questions in order were: \t" + accuracyProofReadstring[0] + "\t" + accuracyProofReadstring[1] + "\t" + accuracyProofReadstring[2] + "\t" + accuracyProofReadstring[3] + "\t" + accuracyProofReadstring[4] + "\t";
                break;
            case 3:
                EnglishScoretxt.text = "Proofreading score: D... questions in order were: \t" + accuracyProofReadstring[0] + "\t" + accuracyProofReadstring[1] + "\t" + accuracyProofReadstring[2] + "\t" + accuracyProofReadstring[3] + "\t" + accuracyProofReadstring[4] + "\t";
                break;
            case 2:
                EnglishScoretxt.text = "Proofreading score: F (40%)... questions in order were: \t" + accuracyProofReadstring[0] + "\t" + accuracyProofReadstring[1] + "\t" + accuracyProofReadstring[2] + "\t" + accuracyProofReadstring[3] + "\t" + accuracyProofReadstring[4] + "\t";
                break;
            case 1:
                EnglishScoretxt.text = "Proofreading score: F (20%)... questions in order were: \t" + accuracyProofReadstring[0] + "\t" + accuracyProofReadstring[1] + "\t" + accuracyProofReadstring[2] + "\t" + accuracyProofReadstring[3] + "\t" + accuracyProofReadstring[4] + "\t";
                break;
            case 0:
                EnglishScoretxt.text = "You got none of the proofreading questions correct... You need to work to improve this because you are failing this class...";
                break;
            default:
                break;
        }
        switch (CodingScore)
        {
            case 5:
                CodingScoretxt.text = "Coding score: A+! questions in order were: \t" + accuracyCodingstring[0] + "\t" + accuracyCodingstring[1] + "\t" + accuracyCodingstring[2] + "\t" + accuracyCodingstring[3] + "\t" + accuracyCodingstring[4] + "\t";
                break;
            case 4:
                CodingScoretxt.text = "Coding score: B+! questions in order were: \t" + accuracyCodingstring[0] + "\t" + accuracyCodingstring[1] + "\t" + accuracyCodingstring[2] + "\t" + accuracyCodingstring[3] + "\t" + accuracyCodingstring[4] + "\t";
                break;
            case 3:
                CodingScoretxt.text = "Coding score: D... questions in order were: \t" + accuracyCodingstring[0] + "\t" + accuracyCodingstring[1] + "\t" + accuracyCodingstring[2] + "\t" + accuracyCodingstring[3] + "\t" + accuracyCodingstring[4] + "\t";
                break;
            case 2:
                CodingScoretxt.text = "Coding score: F (40%)... questions in order were: \t" + accuracyCodingstring[0] + "\t" + accuracyCodingstring[1] + "\t" + accuracyCodingstring[2] + "\t" + accuracyCodingstring[3] + "\t" + accuracyCodingstring[4] + "\t";
                break;
            case 1:
                CodingScoretxt.text = "Coding score: F (20%)... questions in order were: \t" + accuracyCodingstring[0] + "\t" + accuracyCodingstring[1] + "\t" + accuracyCodingstring[2] + "\t" + accuracyCodingstring[3] + "\t" + accuracyCodingstring[4] + "\t";
                break;
            case 0:
                CodingScoretxt.text = "You got none of the Coding questions correct... You need to work to improve this because you are failing this class...";
                break;
            default:
                break;
        }
        switch (HistoryScore)
        {
            case 5:
                HistoryScoretxt.text = "History score: A+! questions in order were: \t" + accuracyReadingCompstring[0] + "\t" + accuracyReadingCompstring[1] + "\t" + accuracyReadingCompstring[2] + "\t" + accuracyReadingCompstring[3] + "\t" + accuracyReadingCompstring[4] + "\t";
                break;
            case 4:
                HistoryScoretxt.text = "History score: B+! questions in order were: \t" + accuracyReadingCompstring[0] + "\t" + accuracyReadingCompstring[1] + "\t" + accuracyReadingCompstring[2] + "\t" + accuracyReadingCompstring[3] + "\t" + accuracyReadingCompstring[4] + "\t";
                break;
            case 3:
                HistoryScoretxt.text = "History score: D... questions in order were: \t" + accuracyReadingCompstring[0] + "\t" + accuracyReadingCompstring[1] + "\t" + accuracyReadingCompstring[2] + "\t" + accuracyReadingCompstring[3] + "\t" + accuracyReadingCompstring[4] + "\t";
                break;
            case 2:
                HistoryScoretxt.text = "History score: F (40%)... questions in order were: \t" + accuracyReadingCompstring[0] + "\t" + accuracyReadingCompstring[1] + "\t" + accuracyReadingCompstring[2] + "\t" + accuracyReadingCompstring[3] + "\t" + accuracyReadingCompstring[4] + "\t";
                break;
            case 1:
                HistoryScoretxt.text = "History score: F (20%)... questions in order were: \t" + accuracyReadingCompstring[0] + "\t" + accuracyReadingCompstring[1] + "\t" + accuracyReadingCompstring[2] + "\t" + accuracyReadingCompstring[3] + "\t" + accuracyReadingCompstring[4] + "\t";
                break;
            case 0:
                HistoryScoretxt.text = "You got none of the History questions correct... You need to work to improve this because you are failing this class...";
                break;
            default:
                break;
        }
        DC.StopAllCoroutines();

    }
    public void onProofReadSelect()
    {
        proofReading.SetActive(true);
        Coding.SetActive(false);
        HistoryReader.SetActive(false);
    }
    public void onDebugCodeSelect()
    {
        proofReading.SetActive(false);
        Coding.SetActive(true);
        HistoryReader.SetActive(false);
    }
    public void onHistoryReadingSelect()
    {
        proofReading.SetActive(false);
        Coding.SetActive(false);
        HistoryReader.SetActive(true);
    }
    public void historyfinished(int questionNumber, bool accurate)
    {
        assignmentsAnswered++;
        accuracyReadingComp[questionNumber - 1] = accurate;
        if (accurate)
        {
            correct++;
        }
        else
        {
            incorrect++;
        }
    }

    public void codingFinished(int questionNumber, bool accurate)
    {
        assignmentsAnswered++;
        accuracyCoding[questionNumber - 1] = accurate;
        if (accurate)
        {
            correct++;
        }
        else
        {
            incorrect++;
        }
    }

    public void ProofReadingFinished(int questionNumber, bool accurate)
    {
        assignmentsAnswered++;
        accuracyReadingComp[questionNumber - 1] = accurate;
        if (accurate)
        {
            correct++;
        }
        else
        {
            incorrect++;
        }
    }
}
