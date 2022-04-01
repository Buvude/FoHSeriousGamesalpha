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
    public DistractionCenter DCMain;
    public string[] commands;
    public int index=1;
    public TextMeshProUGUI output;
    private string outputstring;
    public int puzzleNumber = 1;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void upButtonPress()
    {
        if (index < 10&&puzzleNumber==1)
        {
            commands.SetValue("foward, ", index );
            index++;
            outputstring = "";
            foreach(string s in commands)
            {
                outputstring += s;
            }
            output.text = outputstring;
        }
        else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }
        
    }

    public void leftButtonPress()
    {
        if (index < 10 && puzzleNumber == 1)
        {
            commands.SetValue("turn left, ", index);
            index++;
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
            }
            output.text = outputstring;
        }
        else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }

    }

    public void rightButtonPress()
    {
        if (index < 10 && puzzleNumber == 1)
        {
            commands.SetValue("turn right, ", index);
            index++;
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
            }
            output.text = outputstring;
        }
        else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }

    }

    public void undoButtonPress()
    {
        if (index >= 1&&puzzleNumber==1)
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
        else if (puzzleNumber > 1)
        {
            output.text = "No further puzzels in this version";
        }
        else
        {
            output.text = "you cannot undo what has already been undone (you have undone all commands)";
        }
        

    }
    
    public void submit()
    {
        if (puzzleNumber == 1)
        {
            outputstring = "";
            foreach (string s in commands)
            {
                outputstring += s;
            }
            if (outputstring == "foward, turn right, foward, foward, foward, turn right, foward, foward, turn left, foward, ")
            {
                output.text = "You got the coding question correct";
            }
            else
            {
                output.text = "You got the coding question incorrect";
            }
            puzzleNumber++;
        }
        else if (puzzleNumber > 1)
        {
            output.text = "No further puzzles in this version";
        }
    }

}
