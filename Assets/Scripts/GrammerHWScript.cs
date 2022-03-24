using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrammerHWScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ProofReaderSentance;
    public string q1Correct = "Every time I walk along the beach, my dog runs up to me.";
    public string[] q1Incorrect = {"Ever time I walk along the beach, my dog runs up to me.", "Every time I walk along the birch, my dog runs up to me.","Every time I walk along the beach, my dog runs uo to me."};
    public int randomIndex;
    void Start()
    {
        randomIndex = Random.Range(0, 2);
        ProofReaderSentance.text = "Hello, this is a test";
        //ProofReaderSentance.text = q1Incorrect.GetValue(int.Parse(randomIndex.ToString())).ToString();
        Debug.Log("Text is saying: " + ProofReaderSentance.text.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
