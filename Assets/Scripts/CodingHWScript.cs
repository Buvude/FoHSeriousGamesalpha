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
    public string[] commands;
    public int index=1;
    public TextMeshProUGUI output;
    private string outputstring;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void upButtonPress()
    {
        if (index < 10)
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
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }
        
    }

    public void leftButtonPress()
    {
        if (index < 10)
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
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }

    }

    public void rightButtonPress()
    {
        if (index < 10)
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
        else
        {
            output.text = "Error, you have already used up all 10 moves for this puzzle. use the undo to remove previous moves";
        }

    }

    public void undoButtonPress()
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

}
