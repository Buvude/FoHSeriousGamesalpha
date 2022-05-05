using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificationList : MonoBehaviour
{
    public const int NOTIFICATION_NUMBER= 20; //if you make more then 20 notifications change this number
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


        //each array is set up like this: [#,1]= the notification message/notification text, while [#,2]= notification type. The email from the professor will be at a scripted point, it will be the fourth notification you get.
        //the first one will be an example, so you can copy the way I'm doing it.
        notifications[0,1] = "You have recieved and email from:\n" +
            "Girlfriend\n"+
            "I feel like we haven't talked in weeks. I miss you! I know we're both busy lately and your family's on your case, and all that… I get it, I really do. That doesn't make it less lonely though.";
        notifications[0, 2] = "Email";
        notifications[1,1] = "2";
        notifications[2,1] = "3";
        notifications[3,1] = "N/A";
        notifications[3, 2] = "ProffessorEmail";
        notifications[4,1] = "5";
        notifications[5,1] = "6";
        notifications[6,1] = "7";
        notifications[7,1] = "8";
        notifications[8,1] = "9";
        notifications[9,1] = "10";
        notifications[10,1] = "11";
        notifications[11,1] = "12";
        notifications[12,1] = "13";
        notifications[13,1] = "14";
        notifications[14,1] = "15";
        notifications[15,1] = "16";
        notifications[16,1] = "17";
        notifications[17,1] = "18";
        notifications[18,1] = "19";
        notifications[19,1] = "20";

       
    }
}
