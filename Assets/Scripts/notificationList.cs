using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificationList : MonoBehaviour
{
    public const int NOTIFICATION_NUMBER= 29; //I remembered to change it! ~Casey
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNotifications(string[,] notifications)
    {
        //notification tags: Email     InfightStart       Infight        InfightEnd         SocMed    


        //each array is set up like this: [#,0]= the notification message/notification text, while [#,1]= notification type. The email from the professor will be at a scripted point, it will be the fourth notification you get.
        //the first one will be an example, so you can copy the way I'm doing it.
        notifications[0,0] = "Email from: Girlfriend \n" +
            "I feel like we haven't talked in weeks. I miss you! I know we're both busy lately and your family's on your case, and all that... I get it, I really do. That doesn't make it less lonely though.";
        notifications[0,1] = "Email";
        notifications[1,0] = "Email from: Steambot \n" + "Video Game GOTY Edition and Image Editor 97 from your wishlist are on sale NOW for the next 2 hours!!!!! Get them now!!! Get them now!!! Get them now!!!";
        notifications[1,1] = "Email";
        notifications[2,0] = "Email from: ☆~*♡♡♡Katie9715♡♡♡*~☆ \n" + "H i !!! I am Charlette ,  and I love Singles and Yes Im a girl!!!!!♡ \n \n" + "your so funnyLets Get married!! All I need is y our social security number and a transfer of $1000 to realsinglehothumanwomen.net and WE wil be together ! ! !"; 
        notifications[2,1] = "Email";

        notifications[3,0] = "N/A";
        notifications[3,1] = "ProffessorEmail"; //Please do remember to check your spelling of "professor" across the board. It's fine if it's wrong, as long as it's consistent. ~Casey


        notifications[4,0] = "Cutesy sent a message \n" + "Hey do we have classes on Tuesday?";
        notifications[4,1] = "InfightStart";
        notifications[5,0] = "BadWolf144 sent a message \n" + "no";
        notifications[5,1] = "Infight";
        notifications[6,0] = "Worm on a string sent a message \n" + "YES WE DO??!?!??";
        notifications[6,1] = "Infight";
        notifications[7,0] = "BadWolf144 sent a message \n" + "its a teachers work day";
        notifications[7,1] = "Infight";
        notifications[8,0] = "worth every bit of exposure sent a message \n"+"U mean a conference day?";
        notifications[8,1] = "Infight";
        notifications[9,0] = "BadWolf144 sent a message \n"+"yeah that";
        notifications[9,1] = "Infight";
        notifications[10,0] = "Worm on a string sent a message \n"+"WHAT??>????";
        notifications[10,1] = "Infight";
        notifications[11,0] = "Worm on a string sent a message \n"+"NO";
        notifications[11,1] = "Infight";
        notifications[12,0] = "Worm on a string sent a message \n"+"WHAT";
        notifications[12,1] = "Infight";
        notifications[13,0] = "your mom sent a message \n"+"I did not know that";
        notifications[13,1] = "Infight";
        notifications[14,0] = "Alejandro [admin] sent a message \n"+"Guys, the Teacher’s Union Meeting (which is what I assume @BadWolf144 is referring to) is for the next district over. That’s tomorrow. The Teacher’s Conference is Thursday, and we won’t have class then.";
        notifications[14,1] = "Infight";
        notifications[15,0] = "Worm on a string sent a message \n"+"someone unionize our teachers";
        notifications[15,1] = "Infight";
        notifications[16,0] = "Worm on a string sent a message \n"+"I have a project I don’t wanna finish";
        notifications[16,1] = "Infight";
        notifications[17,0] = "your mom sent a message \n"+"Focus on your homework, Worm";
        notifications[17,1] = "Infight";
        notifications[18,0] = "Worm on a string sent a message \n"+"NO";
        notifications[18,1] = "Infight";
        notifications[19,0] = "Cutesy sent a message \n"+"dang we causin discord in the going to school fandom";
        notifications[19,1] = "InfightEnd";

       notifications[20,0] = "21 friends enjoyed you as a person today! Click here for external validation!";
       notifications[20,1] = "SocMed";
       notifications[21,0] = "Your uncle posted something ignorant and perhaps bigoted. Surely you should dedicate a portion of your time to changing his mind. You’re sure he’ll change his mind if you just reason with him.";
       notifications[21,1] = "SocMed";
       notifications[22,0] = "Your friend Anna posted a picture of her dog!! You can’t ignore this sweet puppy, can you?";
       notifications[22,1] = "SocMed";
       notifications[23,0] = "Someone misinterpreted something you said. If you don’t clarify, this will drive you nuts...";
       notifications[23,1] = "SocMed";
       notifications[24,0] = "Someone on your feed is freaking out and could really use a kind word. This isn’t _your_ responsibility per se, but how can you justify not stepping in?";
       notifications[24,1] = "SocMed";
       notifications[25,0] = "It’s Jacqueline’s birthday! If you don’t wish her a happy birthday, she’ll think you forgot.";
       notifications[25,1] = "SocMed";
       notifications[26,0] = "Oops! Someone unfollowed you. Click to figure out what you did wrong. You’re going to obsess over it either way, so you might as well know the answer.";
       notifications[26,1] = "SocMed";
       notifications[27,0] = "You made a spelling error in your post yesterday. Luckily, no one saw it yet. Click here to correct it so that you don’t look foolish.";
       notifications[27,1] = "SocMed";
       notifications[28,0] = "Someone viewed a photo of you from five years ago! You hate this photo. What were you thinking with that haircut. Log in now to delete it so no one views it again.";
       notifications[28,1] = "SocMed";
    }
}
