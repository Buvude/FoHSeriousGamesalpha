using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int correct, incorrect/*,questionNumber*/;
    public const int TOTAL=15;
    public bool[] accuracyProofRead=new bool[5], accuracyCoding=new bool[5], accuracyReadingComp=new bool[5], copingSkills=new bool[3]; //true is right, false is wrong
    public string[] accuracyProofReadstring = new string[5], accuracyCodingstring = new string[5], accuracyReadingCompstring = new string[5];
    public int assignmentsAnswered = 0, TIME=600, halfTime, finalStretch;//TIMER NUMBER MUST BE SET IN EDITOR
    public Slider HWPercentage, StressMeter;
    public Button copingStrategy1, copingStrategy2, copingStrategy3;
    public TextMeshProUGUI copingStrat1txt, copingStrat2txt, copingStrat3txt, TimerText;
    private int eLAScore = 5, CodingScore = 5, HistoryScore = 5;
   /* public GrammerHWScript gHWS;*/
    public GameObject proofReading, Coding, HistoryReader, gameOver;//*/
    public TextMeshProUGUI EnglishScoretxt, CodingScoretxt, HistoryScoretxt/*, copingscoretxt*/;
    public DistractionCenter DC;
    public AudioSource warningSounds;
    public AudioClip smallWarning, bigWarning;
    public bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        halfTime = TIME / 2;
        finalStretch = TIME / 5;
    }
    public void ToMainGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ToTittleScreen()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
        HWPercentage.value = assignmentsAnswered;
        if (HWPercentage.value == 15&&!stop)
        {
            stop = true;
            finished();
        }

    }

    public void quitTheGame()
    {
        Application.Quit();
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
/*                        copingStrategy1.interactable = true;
*/                        copingStrat1txt.text = "Listening to a song all the way through to get rid of an 'earworm'";
                        break;
                    case 1:
/*                        copingStrategy2.interactable = true;
*/                        copingStrat2txt.text = "Listening to music while you work to help people with ADHD concentrate";
                        break;
                    case 2:
/*                        copingStrategy3.interactable = true;
*/                        copingStrat3txt.text = "Ignoring notifications on your computer unless they pile up can be tricky but worth it";
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
                        copingStrat1txt.text = "???";
                        break;
                    case 1:
                        copingStrategy2.interactable = false;
                        copingStrat2txt.text = "???";
                        break;
                    case 2:
                        copingStrategy3.interactable = false;
                        copingStrat3txt.text = "???";
                        break;
                    default:
                        break;
                }
            }
        }
        Debug.Log(eLAScore + "\n" + HistoryScore + "\n" + CodingScore);
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
    IEnumerator Timer()
    {
        while(TIME>halfTime)
        {
            yield return new WaitForSeconds(1);
            TIME--;
            TimerText.text = TIME.ToString();
        }
        warningSounds.clip = smallWarning;
        warningSounds.loop = true;
        warningSounds.Play();
        while (TIME > finalStretch)
        {
            yield return new WaitForSeconds(1);
            TIME--;
            TimerText.text = TIME.ToString();
        }
        warningSounds.clip = bigWarning;
        warningSounds.loop = true;
        warningSounds.Play();
        while (TIME > 0)
        {
            yield return new WaitForSeconds(1);
            TIME--;
            TimerText.text = TIME.ToString();
        }
        warningSounds.Stop();
        finished();
    }
}
