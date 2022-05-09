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
        commands = new string[10];   
    }
    public Thoughts thou;
    public DistractionCenter DCMain;
    public string[] commands;
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
            commands.SetValue("F, ", index );
            index++;
            outputstring = "";
            foreach(string s in commands)
            {
                outputstring += s;
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
            commands.SetValue("L, ", index);
            index++;
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
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
            commands.SetValue("R, ", index);
            index++;
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
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
            commands.SetValue(" ", index);
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
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
    
    public void submit()
    {
        switch (puzzleNumber)
        {
            case 1:
                {
                    outputstring = "";
                    foreach (string s in commands)
                    {
                        outputstring += s;
                    }
                    if (outputstring == "F, R, F, F, F, R, F, F, L, F, ")
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
                    foreach (string s in commands)
                    {
                        outputstring += s;
                    }
                    if (outputstring == "F, F, L, F, F, R, F, R, F, F, ")
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
                }
            case 3:
                {
                    outputstring = "";
                    foreach (string s in commands)
                    {
                        outputstring += s;
                    }
                    if (outputstring == "F, L, F, L, F, F, L, F, R, F, ")
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
                }
            case 4:
                {
                    outputstring = "";
                    foreach (string s in commands)
                    {
                        outputstring += s;
                    }
                    if (outputstring == "F, F, R, F, F, L, F, F, L, F, ")
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
                }
            case 5:
                {
                    outputstring = "";
                    foreach (string s in commands)
                    {
                        outputstring += s;
                    }
                    if (outputstring == "R, F, F, L, F, F, L, F, F, F, ")
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
                        commands.SetValue("", x);
                    }
                    index = 1;
                    break;
                }
            case 3:
                {
                    puzzle2.SetActive(false);
                    puzzle3.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        commands.SetValue("", x);
                    }
                    index = 1;
                    break;
                }
            case 4:
                {
                    puzzle3.SetActive(false);
                    puzzle4.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        commands.SetValue("", x);
                    }
                    index = 1;
                    break;
                }
            case 5:
                {
                    puzzle4.SetActive(false);
                    puzzle5.SetActive(true);
                    for (int x = 0; x < 10; x++)
                    {
                        commands.SetValue("", x);
                    }
                    index = 1;
                    break;
                }
            default:
                selectionbtn.SetActive(false);
                puzzle5.SetActive(false);
                output.text = "You have finished your coding homework!";
                break;
        }
    }

}
