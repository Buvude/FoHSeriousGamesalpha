using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodingHWScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < enumerations.Length; i++)
        {
            enumerations[i]=commands.None;
        }
        foreach (object s in enumerations)
        {
            outputstring += s.ToString() + "\n";
        }
        output.text = outputstring;
    }
    public enum commands { Forward, Back, Left, Right, None };
    public Thoughts thou;
    public DistractionCenter DCMain;
    //public string[] commands;
    public object[] enumerations = new object[10];
    public int index=1;
    public TextMeshProUGUI output;
    private string outputstring;
    public int puzzleNumber = 1;
    public ScoreManager SM;
    public GameObject selectionbtn, puzzle1, puzzle2, puzzle3, puzzle4, puzzle5;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void upButtonPress()
    {
        if (index < 10/*&&puzzleNumber==1*/)
        {
            enumerations.SetValue(commands.Forward, index );
            index++;
            outputstring = "";
            foreach(object s in enumerations)
            {
                outputstring += s.ToString()+"\n";
                
            }
            output.text = outputstring;
        }
       /* else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }*/
        
    }

    public void leftButtonPress()
    {
        if (index < 10 /*&& puzzleNumber == 1*/)
        {
            enumerations.SetValue(commands.Left, index);
            index++;
            outputstring = "";
            foreach (object s in enumerations)
            {
                outputstring += s.ToString()+"\n";
            }
            output.text = outputstring;
        }
        /* else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
    }
        else
{
    output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
}*/

    }

    public void rightButtonPress()
    {
        if (index < 10/* && puzzleNumber == 1*/)
        {
            enumerations.SetValue(commands.Right, index);
            index++;
            outputstring = "";
            foreach (object s in enumerations)
            {
                outputstring += s.ToString() + "\n";
            }
            output.text = outputstring;
        }
       /* else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }
*/
    }

    public void undoButtonPress()
    {
        if (index >= 1/*&&puzzleNumber==1*/)
        {
            index--;
            enumerations.SetValue(commands.None, index);
            outputstring = "";
            foreach (object s in enumerations)
            {
                outputstring += s.ToString() + "\n";
            }
            output.text = outputstring;
            
        }
       /* else if (puzzleNumber > 1)
        {
            output.text = "No further puzzels in this version";
        }*/
        else
        {
            output.text = "you cannot undo what has already been undone (you have undone all commands)";
        }


    }
    public bool AnswerCheck(int QNum)
    {
        bool correct = false;
        if (QNum == 1)
        {
            //TODO add animation?
            if (enumerations[0].Equals(commands.Forward))
            {
                if (enumerations[1].Equals(commands.Right))
                {
                    if (enumerations[2].Equals(commands.Forward))
                    {
                        if (enumerations[3].Equals(commands.Forward))
                        {
                            if (enumerations[4].Equals(commands.Forward))
                            {
                                if (enumerations[5].Equals(commands.Right))
                                {
                                    if (enumerations[6].Equals(commands.Forward))
                                    {
                                        if (enumerations[7].Equals(commands.Forward))
                                        {
                                            if (enumerations[8].Equals(commands.Left))
                                            {
                                                if (enumerations[9].Equals(commands.Forward))
                                                {
                                                    correct = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (QNum == 2)
        {
            //TODO add animation?
            if (enumerations[0].Equals(commands.Forward))
            {
                if (enumerations[1].Equals(commands.Forward))
                {
                    if (enumerations[2].Equals(commands.Left))
                    {
                        if (enumerations[3].Equals(commands.Forward))
                        {
                            if (enumerations[4].Equals(commands.Forward))
                            {
                                if (enumerations[5].Equals(commands.Right))
                                {
                                    if (enumerations[6].Equals(commands.Forward))
                                    {
                                        if (enumerations[7].Equals(commands.Right))
                                        {
                                            if (enumerations[8].Equals(commands.Forward))
                                            {
                                                if (enumerations[9].Equals(commands.Forward))
                                                {
                                                    correct = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (QNum == 3)
        {
            //TODO add animation?
            if (enumerations[0].Equals(commands.Forward))
            {
                if (enumerations[1].Equals(commands.Left))
                {
                    if (enumerations[2].Equals(commands.Forward))
                    {
                        if (enumerations[3].Equals(commands.Left))
                        {
                            if (enumerations[4].Equals(commands.Forward))
                            {
                                if (enumerations[5].Equals(commands.Forward))
                                {
                                    if (enumerations[6].Equals(commands.Left))
                                    {
                                        if (enumerations[7].Equals(commands.Forward))
                                        {
                                            if (enumerations[8].Equals(commands.Right))
                                            {
                                                if (enumerations[9].Equals(commands.Forward))
                                                {
                                                    correct = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (QNum == 4)
        {
            //TODO add animation?
            if (enumerations[0].Equals(commands.Forward))
            {
                if (enumerations[1].Equals(commands.Forward))
                {
                    if (enumerations[2].Equals(commands.Right))
                    {
                        if (enumerations[3].Equals(commands.Forward))
                        {
                            if (enumerations[4].Equals(commands.Forward))
                            {
                                if (enumerations[5].Equals(commands.Left))
                                {
                                    if (enumerations[6].Equals(commands.Forward))
                                    {
                                        if (enumerations[7].Equals(commands.Forward))
                                        {
                                            if (enumerations[8].Equals(commands.Left))
                                            {
                                                if (enumerations[9].Equals(commands.Forward))
                                                {
                                                    correct = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (QNum == 5)
        {
            //TODO add animation?
            if (enumerations[0].Equals(commands.Right))
            {
                if (enumerations[1].Equals(commands.Forward))
                {
                    if (enumerations[2].Equals(commands.Forward))
                    {
                        if (enumerations[3].Equals(commands.Left))
                        {
                            if (enumerations[4].Equals(commands.Forward))
                            {
                                if (enumerations[5].Equals(commands.Forward))
                                {
                                    if (enumerations[6].Equals(commands.Left))
                                    {
                                        if (enumerations[7].Equals(commands.Forward))
                                        {
                                            if (enumerations[8].Equals(commands.Forward))
                                            {
                                                if (enumerations[9].Equals(commands.Forward))
                                                {
                                                    correct = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return correct;
    }
    public void submit()
    {
        switch (puzzleNumber)
        {
            case 1:
                {
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString();
                    }
                    /*if (outputstring == "F, R, F, F, F, R, F, F, L, F, ")
                    {
                        SM.codingFinished(1, true); these are the old way of checking the answers... and they didn't work anyways
                    }*/
                    if (AnswerCheck(1))
                    {
                        SM.codingFinished(1, true);
                    }
                    else
                    {
                        SM.codingFinished(1, false);
                    }
                    puzzleNumber++;
                    thou.firstkTimeCode = false;
                    NextPuzzle();
                    break;

                }
            case 2:
                {
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString();
                    }

                    if (AnswerCheck(2))
                    {
                        SM.codingFinished(2, true);
                    }
                    else
                    {
                        SM.codingFinished(2, false);
                    }
                    puzzleNumber++;
                    NextPuzzle();
                    break;
                    /*if (outputstring == "F, F, L, F, F, R, F, R, F, F, ")
                    {
                        SM.codingFinished(2, true);
                    }*/
                }
            case 3:
                {
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString();
                    }

                    if (AnswerCheck(3))
                    {
                        SM.codingFinished(3, true);
                    }
                    else
                    {
                        SM.codingFinished(3, false);
                    }
                    puzzleNumber++;
                    NextPuzzle();
                    break;
                    /* if (outputstring == "F, L, F, L, F, F, L, F, R, F, ")
                     {
                         SM.codingFinished(3, true);
                     }*/

                }
            case 4:
                {
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString();
                    }

                    if (AnswerCheck(4))
                    {
                        SM.codingFinished(4, true);
                    }
                    else
                    {
                        SM.codingFinished(4, false);
                    }
                    puzzleNumber++;
                    NextPuzzle();
                    break;
                    /* if (outputstring == "F, F, R, F, F, L, F, F, L, F, ")
                     {
                         SM.codingFinished(4, true);
                     }*/

                }
            case 5:
                {
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString();
                    }

                    if (AnswerCheck(5))
                    {
                        SM.codingFinished(5, true);
                    }
                    else
                    {
                        SM.codingFinished(5, false);
                    }
                    puzzleNumber++;
                    NextPuzzle();
                    break;
                    /*if (outputstring == "R, F, F, L, F, F, L, F, F, F, ")
                    {
                        SM.codingFinished(5, true);
                    }*/

                }
            default:
                selectionbtn.SetActive(false);
                puzzle5.SetActive(false);
                output.text = "You have finished your coding homework!";
                break;
        }
    }
    public void NextPuzzle()
    {
        switch (puzzleNumber)
        {
            case 2:
                {
                    puzzle1.SetActive(false);
                    puzzle2.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        enumerations.SetValue(commands.None, x);
                    }
                    index = 0;
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString() + "\n";
                    }
                    output.text = outputstring;
                    break;
                }
            case 3:
                {
                    puzzle2.SetActive(false);
                    puzzle3.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        enumerations.SetValue(commands.None, x);
                    }
                    index = 0;
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString() + "\n";
                    }
                    output.text = outputstring;
                    break;
                }
            case 4:
                {
                    puzzle3.SetActive(false);
                    puzzle4.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        enumerations.SetValue(commands.None, x);
                    }
                    index = 0;
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString() + "\n";
                    }
                    output.text = outputstring;
                    break;
                }
            case 5:
                {
                    puzzle4.SetActive(false);
                    puzzle5.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        enumerations.SetValue(commands.None, x);
                    }
                    index = 0;
                    outputstring = "";
                    foreach (object s in enumerations)
                    {
                        outputstring += s.ToString() + "\n";
                    }
                    output.text = outputstring;
                    break;
                }
            default:
                submit();
                break;
        }
    }

}
