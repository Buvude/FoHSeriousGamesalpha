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
    private string q1p1 = "Rising tensions and unsafe working conditions among factory employees led to the first of the Anderson Inc.strikes in New Deathhaven, which served as the building blocks for the formation of the tailors' union. Lillian Vandersnax the 3rd planned the assassination of the Anderson company president before the contract was signed but she escaped New Deathhaven with her wife Gracelyn Madelyne Evelynne LeMort before charges could be pressed against her. No historical records have been found as to where she went or what she did afterward; the only reasons historians know about the escape is due to an elaborate set of clues Lillian left behind, leading police on a wild goose chase with the final clue reading \"by the time you've finished my game, I shall be living under a new name.\"\n  \n";
    private string q1p2 = "Nobody actually knows who the first discoverer of the Martian Watch Tower was, but several diaries swear up and down that it was an eccentric Nigerian astronomer named Emomu Aaye - Ajeji - Aaye.British \"explorer\" Thomas Eels English insisted in his record that looking for the tower was his idea in the first place, while Emomu herself attributed the findings to several of her colleagues and referred to Thomas in her writings as (loosely translated) \"a very large child pretending as an intellectual\".This dispute, as well as the ensuing legal battle, led to the conversion of the English family confectionery business into a base for British military forces.The ensuing conflict was largely embarrassing for the British government and candyfloss - based combat was immediately retired and stricken from European history books.\n  \n";
    private string q1p3 = "The last war fought by Admiral Colonel Sergeant Gary \"Garry\" Garrison - Grover took place in the berry fields of East Jerusalem.The war consisted of a dispute that broke out when Gary stepped on a shopkeeper's toes and refused to apologize. \"It became a whole thing,\" Gary would later recount in his memoir. \"Scariest war I've ever been in. I didn\'t realize what I\'d done at first, so I thought the guy was being unreasonable.But then his son came out and asked what happened, and that\'s when I noticed that the guy had crutches, and his foot was probably already messed up. But by then the son was yelling at me, and I\'d already defended myself, and it was too late to back down and apologize.Then this nice older lady came over asking what all the fuss was about, and all I could do was just stay quiet.I wanted to crawl into a hole.It was so awkward, oh my god.\" Gary passed away in the early 1500\'s, having only just held on long enough to see the turn of the century.";
    public GameObject paragraphSelectors, historySelectionBtn;
    public ScoreManager sM;
    public Thoughts thou;
    // Start is called before the first frame update
    void Start()
    {
        textBookParagraphs.text = "";
        answerA.text = "Paragraph 1";
        answerB.text = "paragraph 2";
        answerC.text = "paragraph 3";
        answerD.text = " The answer is not in the text";
        question.text = "What was the primary cause of the 1541 Cotton Candy Wars?";
        //q3Correct = Random.Range(1,5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnswerAPressed()
    {
        if (questionNumber == 1)
        {
            sM.historyfinished(1, false);
            nextHistoryQuestion();
        }

        else if (questionNumber == 2)
        {
            sM.historyfinished(2, true);
            nextHistoryQuestion();
        }

        else if (questionNumber == 3)
        {
            if (DCMain.q3Correct == 1)
            {
                sM.historyfinished(3, true);
                sM.copingSkills[2] = true;
                nextHistoryQuestion();
            }
            else
            {
                sM.historyfinished(3, false);
                nextHistoryQuestion();
            }
        }
        else if (questionNumber == 4)
        {
            sM.historyfinished(4, false);
            nextHistoryQuestion();
        }
        else if (questionNumber == 5)
        {
            sM.historyfinished(5, false);
            nextHistoryQuestion();
        }
    }
    public void AnswerBPressed()
    {
        if (questionNumber == 1)
        {
            sM.historyfinished(1, true);
            nextHistoryQuestion();
        }

        else if (questionNumber == 2)
        {
            sM.historyfinished(2, false);
            nextHistoryQuestion();
        }

        else if (questionNumber == 3)
        {
            if (DCMain.q3Correct == 2)
            {
                sM.historyfinished(3, true);
                sM.copingSkills[2] = true;
                nextHistoryQuestion();
            }
            else
            {
                sM.historyfinished(3, false);
                nextHistoryQuestion();
            }
        }
        else if (questionNumber == 4)
        {
            sM.historyfinished(4, true);
            nextHistoryQuestion();
        }
        else if (questionNumber == 5)
        {
            sM.historyfinished(5, false);
            nextHistoryQuestion();
        }
    }
    public void AnswerCPressed()
    {
        if (questionNumber == 1)
        {
            sM.historyfinished(1, false);
            nextHistoryQuestion();
        }

        else if (questionNumber == 2)
        {
            sM.historyfinished(1, false);
            nextHistoryQuestion();
        }
        else if (questionNumber == 3)
        {
            if (DCMain.q3Correct == 3)
            {
                sM.historyfinished(3, true);
                sM.copingSkills[2] = true;
                nextHistoryQuestion();
            }
            else
            {
                sM.historyfinished(3, false);
                nextHistoryQuestion();
            }
        }
        else if (questionNumber == 4)
        {
            sM.historyfinished(4, false);
            nextHistoryQuestion();
        }
        else if (questionNumber == 5)
        {
            sM.historyfinished(5, false);
            nextHistoryQuestion();
        }
    }
    public void AnswerDPressed()
    {
        if (questionNumber == 1)
        {
            sM.historyfinished(1, false);
            nextHistoryQuestion();
        }

        else if (questionNumber == 2)
        {
            sM.historyfinished(1, false);
            nextHistoryQuestion();
        }

        else if (questionNumber == 3)
        {
            if (DCMain.q3Correct == 4)
            {
                sM.historyfinished(3, true);
                sM.copingSkills[2] = true;
                nextHistoryQuestion();
            }
            else
            {
                sM.historyfinished(3, false);
                nextHistoryQuestion();
            }
        }
        else if (questionNumber == 4)
        {
            sM.historyfinished(4, false);
            nextHistoryQuestion();
        }
        else if (questionNumber == 5)
        {
            sM.historyfinished(5, true);
            nextHistoryQuestion();
        }
    }

    public void paragraph1btnPressed()
    {
        textBookParagraphs.text = q1p1;
    }

    public void paragraph2btnPressed()
    {
        textBookParagraphs.text = q1p2;
    }

    public void paragraph3btnPressed()
    {
        textBookParagraphs.text = q1p3;
    }

    public void nextHistoryQuestion()
    {
        questionNumber++;
        switch (questionNumber)
        {
            case 2:
                {
                    thou.firstTimeReadComp = false;
                    question.text = "Question 2: How many animals (not including humans) got medals of honour in the war of 2476?";
                    answerA.text = "6";
                    answerB.text = "3";
                    answerC.text = "4";
                    answerD.text = "10";
                    textBookParagraphs.text = "The war of 2476 was easily the most well-documented war in Earth’s history, due to it being broadcast live in its entirety over every known medium. Despite being called “more of a game show than an actual war” by Western Hemisphere Leiutenant General Commander Mark Hamhands, medals of honour were still awarded, controversially, to a variety of heroic actors. The awardees were, in chronological order: John Jamesworth Jackalson (a man from New California who stopped a bus full of baby koalas from hurtling into the sun), Henry Waddlesworth Longfellow (a penguin who convinced the Australian emu army to join the human forces), A. B. Barnes (a small capuchin who was able to crawl into a collapsed cave and bring water to the cave people), Fluffles “Scuffles” Taylor (a concerned citizen who was able to fight off a hostile conspiracy theorist while authorities searched his bank records), Spot the Dog (a VR game about finding dogs that proved useful in hunting enemy forces), two women simply named Asuka (one being a ghost that claims to embody the persona of a Japanese wrestler, the other being a shiba inu who somehow learned to use a crossbow), and three unnamed bears with armour and ballistic weapons stuck onto them by an engineer whose allegiances are unknown.";
                    paragraphSelectors.SetActive(false);
                    break;
                }
            case 3:
                {
                    question.text = "Question 3: What was the Cincinnati Scoundrel’s first name?"/* + DCMain.q3Correct*/;
                    answerA.text = " Bubbles";
                    answerB.text = "Dave";
                    answerC.text = "Wimbledon";
                    answerD.text = "Stabby";
                    textBookParagraphs.text = "Ah… I don't remember this one. Or where to find it in my book.";
                    paragraphSelectors.SetActive(false);
                    break;
                }
            case 4:
                {
                    paragraphSelectors.SetActive(true);
                    question.text = "Question 4: Which river used to run through Chevalhorse Canyon?";
                    answerA.text = "Lake Emu";
                    answerB.text = "Wetwater";
                    answerC.text = "Llên-ladrad";
                    answerD.text = "none of the above";
                    textBookParagraphs.text = "";
                    q1p3 = "Wetwater Canyon was the name of a large rock formation discovered in 1872.It was named for the lake that ran through it, which in turn was named by a figure historians call “General Scribbles” due to the handwriting in his diaries which do not mention his actual name. Scribbles’ diaries explain that he named the river “Wetwater” as an insulting gesture toward his political rival Donovan, with whom he was in a years-long feud over whether or not water was wet. If Scribbles’ later writings are to be believed, Donovan dried up the lake himself leaving only a few scattered puddles of mud, in an attempt to demonstrate how water, when not surrounded by sufficiently more water, could in fact be rendered dry. However, some historians believe that Scribbles dried up the lake himself to prove that a dry lake would have no water at all, blaming Donovan for the deed instead when it proved unpopular.The canyon was rediscovered a century later by colonizers who had no knowledge of its history, and it was they who gave it the name we know it by today.The new name, it seems, came from a similar debate about horses.";
                    q1p2 = "Lake Emu is a large body of water in Australia that has been inaccessible to humans since the Great Emu War of 1932. Though it runs through several beautiful landmarks, humanity has given up on reclaiming the territory ever since emus learned how to operate automatic rifles. Evidence uncovered by fearless historians and human-avian diplomats suggests that the valley surrounding the North end of Lake Emu used to be overrun with feral horses, but they all mysteriously disappeared long before humans ever lived there.";
                    q1p1 = "The River Llên-ladrad first appeared on cartographer Llywellyn Gittins-Prosser’s comprehensive map of the French countryside. This map was only discovered after Llywellyn’s death, and explorers scrambled to find the previously-undiscovered river. Many failed or perished in their pursuit, due to the river’s location being nigh-inaccessible, running through a small canyon surrounded by treacherous mountains. Llywellyn’s wife, who had been unaware for two years of the uproar regarding the map, eventually clarified that her spouse had fabricated the existence of the river as a legal defense against having their map copied.";
                    break;
                }
            case 5:
                {
                    paragraphSelectors.SetActive(false);
                    question.text = "Question 5: What was the worst-received game ever made by Serious Games LLC?";
                    textBookParagraphs.text = "Serious Games, LLC was a publisher known for its educational and skill-building games, many of which are created to raise awareness of social issues. Many of their games received critical acclaim and are held as classics today, such as Jacob’s Parents, a visual novel about growing up in an abusive household based on the author’s own experiences; The Right Path, a simulation game about leading an ethics committee that encourages players to confront hard moral questions; and Bradley’s Burger Farm, an illuminating and well-researched time-management game that teaches players about the meat industry in a manner so nuanced that it was publicly decried by PETA, a factor that contributed to its popularity in the first place. However, the company has had its fair share of backlash and controversy as well.Games like Grief Simulator and Mental Killness were criticized heavily for their haphazard portrayal of dark subjects, though the company’s relative obscurity at the time of their release gave them some benefit of the doubt among their defenders.The worst - received titles in order of release are Mental Killness, Time Travelling Bob, Misaimed Amy, Misguided Amy, Bad Lettuce, and Mathketball Superstars.The games that sparked the most controversy were games seen as poorly handling difficult subjects, but the only universally - disliked title is the company’s first attempt at a math game.Game journalist Yolandi S said of the discrepancy, “While even Misaimed Amy had supporters who agreed with its unintentional message or who interpreted the game’s events differently, a bad math game doesn’t speak to anybody.It’s just a bad math game.”";
                   answerA.text = "Jacob's Parents";
                    answerB.text = "Grief Simulator";
                    answerC.text = "Mental Killness";
                    answerD.text = "Mathketball Superstars";
                    break;
                }
            default:
                question.text = "You've finished this section of homework!";
                historySelectionBtn.SetActive(false);
                break;
        }
    }
}
