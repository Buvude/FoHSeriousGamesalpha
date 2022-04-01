using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HistoryHWScript : MonoBehaviour
{
    public DistractionCenter DCMain;
    public int questionNumber = 1;
    public TextMeshProUGUI textBookParagraphs, answerA, answerB, answerC, answerD, question;
    // Start is called before the first frame update
    void Start()
    {
         textBookParagraphs.text= 
        "Rising tensions and unsafe working conditions among factory employees led to the first of the Anderson Inc.strikes in New Deathhaven, which served as the building blocks for the formation of the tailors' union. Lillian Vandersnax the 3rd planned the assassination of the Anderson company president before the contract was signed but she escaped New Deathhaven with her wife Gracelyn Madelyne Evelynne LeMort before charges could be pressed against her. No historical records have been found as to where she went or what she did afterward; the only reasons historians know about the escape is due to an elaborate set of clues Lillian left behind, leading police on a wild goose chase with the final clue reading \"by the time you've finished my game, I shall be living under a new name.\"\n  \n"+ 
        "Nobody actually knows who the first discoverer of the Martian Watch Tower was, but several diaries swear up and down that it was an eccentric Nigerian astronomer named Emomu Aaye - Ajeji - Aaye.British \"explorer\" Thomas Eels English insisted in his record that looking for the tower was his idea in the first place, while Emomu herself attributed the findings to several of her colleagues and referred to Thomas in her writings as (loosely translated) \"a very large child pretending as an intellectual\".This dispute, as well as the ensuing legal battle, led to the conversion of the English family confectionery business into a base for British military forces.The ensuing conflict was largely embarrassing for the British government and candyfloss - based combat was immediately retired and stricken from European history books.\n  \n"+ 
        "The last war fought by Admiral Colonel Sergeant Gary \"Garry\" Garrison - Grover took place in the berry fields of East Jerusalem.The war consisted of a dispute that broke out when Gary stepped on a shopkeeper's toes and refused to apologize. \"It became a whole thing,\" Gary would later recount in his memoir. \"Scariest war I've ever been in. I didn\'t realize what I\'d done at first, so I thought the guy was being unreasonable.But then his son came out and asked what happened, and that\'s when I noticed that the guy had crutches, and his foot was probably already messed up. But by then the son was yelling at me, and I\'d already defended myself, and it was too late to back down and apologize.Then this nice older lady came over asking what all the fuss was about, and all I could do was just stay quiet.I wanted to crawl into a hole.It was so awkward, oh my god.\" Gary passed away in the early 1500\'s, having only just held on long enough to see the turn of the century.";
        answerA.text = "Paragraph 1";
        answerB.text = "paragraph 2";
        answerC.text = "paragraph 3";
        answerD.text = " The answer is not in the text";
        question.text = "What was the primary cause of the 1541 Cotton Candy Wars?\n" +
            "(Select the paragraph that answers the question.)";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerBPressed()
    {
        if (questionNumber == 1)
        {

        }
    }

}
