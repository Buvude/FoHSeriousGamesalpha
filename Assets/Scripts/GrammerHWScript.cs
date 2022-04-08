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
    public string q1Correct = "Every time I walk along the beach, my dog runs up to me.";
    public string[] q1Incorrect = {"Ever time I walk along the beach, my dog runs up to me.", "Every time I walk along the birch, my dog runs up to me.","Every time I walk along the beach, my dog runs uo to me."};
    public int randomIndex, proofReadingQuestionNumber;
    public Button submitBtn, resetBtn, instructionsBtn;
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

    public void onSubmit()
    {
        if (proofReadingQuestionNumber == 1)
        {
            if (iField.text == q1Correct)
            {
                sM.accuracyProofRead.SetValue(false, sM.questionNumber);
                sM.questionNumber++;
                sM.correct++;
                proofReadingQuestionNumber++;
            }
            else
            {
                sM.accuracyProofRead.SetValue(true, sM.questionNumber);
                sM.questionNumber++;
                sM.incorrect++;
                proofReadingQuestionNumber++;
            }
        }
       
    }
    public void onReset()
    {
        switch (proofReadingQuestionNumber)
        {
            case 1:
                iField.text = q1Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
                break;
            default:
                iField.text = "Error, no question ready for this";
                break;
        }
    }

}
