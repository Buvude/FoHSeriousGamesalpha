using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public int score;
    public Text scoretxt;
    public UnityEngine.Object obj;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "score: " + score;
    }
    public void buttonclick()
    {
        score++;
    }
    

    
}
