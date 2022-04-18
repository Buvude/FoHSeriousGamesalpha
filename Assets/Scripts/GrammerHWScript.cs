using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GrammerHWScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreManager sM;
    //public Text ProofReaderSentancePlaceHolder,proofReaderSentanceTrue;
    public Text questionNumber;
    public TMP_InputField iField;
    public string q1Correct = "Every time I walk along the beach, my dog runs up to me.",
                  q2Correct = "I wandered into the kitchen, keeping myself upright with the last of my strength.",
                  q3Correct = "None of my closest friends know my secret recipe.",
                  q4Correct = "The only thing Richard wants is to be left alone, eating lasagna and reading graphic novels.",
                  q5Correct = "A pretty young woman strolls into the castle garden at twilight, watching the birds.";
    public string[] q1Incorrect = { "Ever time I walk along the beach, my dog runs up to me.", "Every time I walk along the birch, my dog runs up to me.", "Every time I walk along the beach, my dog runs uo to me." },
                    q2Incorrect = { "I wandered into the kitchen, keeping myself upright with the last of my strenght.", "I wandred into the kithen, keeping myself upright with the last of my strength.", "I wondered into the kitchen, kepping myself upright with the last of my strenth." },
                    q3Incorrect = { "None of my closest friends know my secret recipie.", "None of my closets freinds know my secret recipe.", "Nonw of my closest friends known my secret recippe." },
                    q4Incorrect = { "The only thing Richard wants is to be left alone, eating lasana and reading graphic novels.", "The only thing Richard wants is to be left alone, eating lasagnia and reading graphtic novels.", "The only thing Richard wants is too be left alone, eating lasanga and reading graphic novells." },
                    q5Incorrect = { "A prety young woman strolls into the castle garden at twilight, watching the birds.", "A pretty young woman strolls into the caste garden at twiight, watching the birds.", "A pretty young woman stroles into the castle garden at twlight, whatching the birds." };

    
    public int randomIndex, proofReadingQuestionNumber;
    public Button submitBtn, resetBtn, instructionsBtn, selectionBtn;
    public DistractionCenter DCMain;
    void Start()
    {
        proofReadingQuestionNumber = 1;
        randomIndex = Random.Range(0, 2);
        //ProofReaderSentancePlaceHolder.text = "Hello, this is a test";
        iField.text = q1Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
        //Debug.Log("Text is saying: " + ProofReaderSentancePlaceHolder.text.ToString());
        //iField.text = ProofReaderSentancePlaceHolder.text;
    }

    // Update is called once per frame
    void Update()
    {
        questionNumber.text = "Question Number "+proofReadingQuestionNumber.ToString()+":";
    }
   /* public void setStrings()
    {
        proofReaderSentanceTrue.text = "Hello, this is a test";
    }*/

    public void onSubmit() //checking to see if your answers are right
    {
        switch (proofReadingQuestionNumber)
        {
            case 1:
                {
                    if (iField.text == q1Correct)
                    {
                        sM.ProofReadingFinished(1, true);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    else
                    {
                        sM.ProofReadingFinished(1, false);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                }
                break;
            case 2:
                {
                    if (iField.text == q2Correct)
                    {
                        sM.ProofReadingFinished(2, true);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    else
                    {
                        sM.ProofReadingFinished(2, false);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    break;
                }
            case 3:
                {
                    if (iField.text == q3Correct)
                    {
                        sM.ProofReadingFinished(3, true);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    else
                    {
                        sM.ProofReadingFinished(3, false);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                }
                break;
            case 4:
                {
                    if (iField.text == q4Correct)
                    {
                        sM.ProofReadingFinished(4, true);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    else
                    {
                        sM.ProofReadingFinished(4, false);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                }
                break;
            case 5:
                {
                    if (iField.text == q5Correct)
                    {
                        sM.ProofReadingFinished(5, true);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                    else
                    {
                        sM.ProofReadingFinished(5, false);
                        proofReadingQuestionNumber++;
                        nextQuestion();
                    }
                }
                break;
            default:
                break;
        }
        /*if (proofReadingQuestionNumber == 1)
        {
            if (iField.text == q1Correct)
            {
                sM.ProofReadingFinished(1, true);
                *//*sM.accuracyProofRead.SetValue(false, sM.questionNumber);
                sM.questionNumber++;
                sM.correct++;
                proofReadingQuestionNumber++;*//*
            }
            else
            {
                sM.ProofReadingFinished(1, false);
                *//*sM.accuracyProofRead.SetValue(true, sM.questionNumber);
                sM.questionNumber++;
                sM.incorrect++;
                proofReadingQuestionNumber++;*//*
            }
        }*/

    }
    public void nextQuestion()
    {
        switch (proofReadingQuestionNumber)
        {
            case 2:
                {
                    randomIndex = Random.Range(0, 2);
                    iField.text = q2Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                    break;
                }
            case 3:
                {
                    randomIndex = Random.Range(0, 2);
                    iField.text = q3Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                    break;
                }
            case 4:
                {
                    randomIndex = Random.Range(0, 2);
                    iField.text = q4Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                    break;
                }
            case 5:
                {
                    randomIndex = Random.Range(0, 2);
                    iField.text = q5Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                    break;
                }
            default:
                selectionBtn.gameObject.SetActive(false);
                iField.text = "No more questions!";
                break;
        }
    }
    public void onReset()
    {
        switch (proofReadingQuestionNumber)
        {
            case 1:
                iField.text = q1Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            case 2:
                iField.text = q2Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            case 3:
                iField.text = q3Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            case 4:
                iField.text = q4Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            case 5:
                iField.text = q5Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            default:
                iField.text = "Error, no question ready for this";
                break;
        }
    }

}
