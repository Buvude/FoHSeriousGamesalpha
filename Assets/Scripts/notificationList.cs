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


        //each array is set up like this: [#,0]= the notification message/notification text, while [#,2]= notification type. The email from the professor will be at a scripted point, it will be the fourth notification you get.
        //the first one will be an example, so you can copy the way I'm doing it.
        notifications[0,0] = "You have recieved and email from:\n" +
            "Girlfriend\n"+
            "I feel like we haven't talked in weeks. I miss you! I know we're both busy lately and your family's on your case, and all that… I get it, I really do. That doesn't make it less lonely though.";
        notifications[0,1] = "Email";
        notifications[1,0] = "2";
        notifications[2,0] = "3";
        notifications[3,0] = "N/A";
        notifications[3,1] = "ProffessorEmail";
        notifications[4,0] = "Infight 1/3 Test";
        notifications[4,1] = "InfightStart";
        notifications[5,0] = "Infight 2/3 Test";
        notifications[5,1] = "Infight";
        notifications[6,0] = "Infight 3/3 Test";
        notifications[6,1] = "InfightEnd";
        notifications[7,0] = "8";
        notifications[8,0] = "9";
        notifications[9,0] = "10";
        notifications[10,0] = "11";
        notifications[11,0] = "12";
        notifications[12,0] = "13";
        notifications[13,0] = "14";
        notifications[14,0] = "15";
        notifications[15,0] = "16";
        notifications[16,0] = "17";
        notifications[17,0] = "18";
        notifications[18,0] = "19";
        notifications[19,0] = "20";

       
    }
}
