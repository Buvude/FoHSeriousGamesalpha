using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistractionCenter : MonoBehaviour
{
    public bool corutineMentalGoing = false, mentalDistractionHappening = false;
    public string var;
    public AudioSource MentalDistraction, PhysichalDistraction, ComputerDistraction;
    public AudioClip SynthroidShort, SynthroidFull, emailNotif, infightNotif, socMedNotif;
    public TextMeshProUGUI notificationText;
    public string[,] notifications;
    public int notificationsQueued = 0, notificationsRead=0, totalNotificationsSpawned=0;
    public ScoreManager SM;
    public notificationList notifList;
    public HistoryHWScript hist;
    public int q3Correct;
    //public GameObject mentalChoices, phisichalChoices, computerChoices;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        q3Correct = Random.Range(1, 5);
        //MentalDistractionSpawn();
        notifications = new string[NOTIFICATION_NUMBER,2];
        notifList.setNotifications(notifications);
        /*for (int i = 0; i < 40; i++)
        {
            spawnComputerDistraction();
        }
        TeacherEmail(2);*/
        StartCoroutine("ComputerDistractionTime");
        StartCoroutine("MentalDistractionTime");
    }
    public const int NOTIFICATION_NUMBER = notificationList.NOTIFICATION_NUMBER;
    // Update is called once per frame
    void Update()
    {
        
        totalNotificationsSpawned = notificationsQueued + notificationsRead;
        if (!MentalDistraction.isPlaying&&!corutineMentalGoing)
        {
            StartCoroutine("MentalDistractionTime");
        }
        if (MentalDistraction.isPlaying)
        {
            StopCoroutine("MentalDistractionTime");
        }
        if (!MentalDistraction.isPlaying && mentalDistractionHappening)
        {
            if (MentalDistraction.volume < 1f)
            {
                MentalDistraction.volume += .1f;
                MentalDistraction.Play();
            }
            else if (MentalDistraction.pitch < 3f)
            {
                MentalDistraction.pitch += .1f;
                MentalDistraction.Play();
            }
        }
        /*Debug.Log("testII");*/
        if (/*Input.GetKey("s") &&*/ Input.GetKey("c") && Input.GetKeyDown("d"))
        {
            Debug.Log("testIII");
            spawnComputerDistraction();
        }
    }

    

    IEnumerator ComputerDistractionTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            spawnComputerDistraction();
        }
    }

    IEnumerator MentalDistractionTime()
    {
        corutineMentalGoing = true;
        while (true)
        {
            yield return new WaitForSeconds(45);
            MentalDistractionSpawn();
            corutineMentalGoing = false;
            StopCoroutine("MentalDistractionTime");
        }
    }

    public void MentalDistractionSpawn()
    {
        MentalDistraction.volume = .5f;
        MentalDistraction.clip=SynthroidShort;
        MentalDistraction.loop=false;
        MentalDistraction.Play();
        mentalDistractionHappening = true;
        //posterText.text = "Mental distractions will have many different forms, but for this demo we have an earworm, or a song that is stuck in your head. According to research a good way to deal with this is to listen to the song from start to end. In the full game, the longer that the song is stuck in your head, the harder it is to focus, and the more anxiety you will get, and the louder it will become.";
        //mentalChoices.SetActive(true);

    }
    public void mentatlDistractitonSynthroidFullSong()
    {
        MentalDistraction.volume = 1f;
        mentalDistractionHappening = false;
        MentalDistraction.clip = SynthroidFull;
        MentalDistraction.pitch = 1;
        MentalDistraction.loop = false;
        MentalDistraction.Play();
        //mentalChoices.SetActive(false);
        SM.copingSkills[0] = true;
        SM.copingSkills[1] = true;
        
    }
    public void spawnPhysichalDistraction()
    {
        //TODO start conversation sound effect
        //posterText.text = "this will start a conversation that is distracting (probably a domestic dispute because it is distracting)";
    }

    public void spawnComputerDistraction()
    {
        //posterText.text = "This will cause a notification sound effect and add a notification to the notification queue (which you can then check, and dismiss notifications or read them (some need to be read, or else you might get a question wrong))";
        switch (notifications[notificationsRead,1])
        {
            case "Email":
                ComputerDistraction.clip = emailNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();//do this for all notificaiton types (for the sounds)
                break;
            case "ProffessorEmail":
                ComputerDistraction.clip = emailNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();
                TeacherEmail(q3Correct);
                break;
            case "InfightStart":
                StopCoroutine("ComputerDistractionTime");
                StartCoroutine("infightNotifications");
                ComputerDistraction.clip = infightNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();
                break;
            case "Infight":
                ComputerDistraction.clip = infightNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();
                break;
            case "InfightEnd":
                StartCoroutine("ComputerDistractionTime");
                StopCoroutine("infightNotifications");
                ComputerDistraction.clip = infightNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();
                break;
            case "SocMed":
                ComputerDistraction.clip = socMedNotif;
                ComputerDistraction.loop = false;
                ComputerDistraction.Play();
                break;
            default:
                break;
        }
        notificationsQueued++;
        checkNotificationQueue();
    }

    public void checkNotificationQueue()
    {
        if (notificationsQueued > 0)
        {
            //TODO add 20 notifications and notification descriptions
            notificationText.text = (notifications[notificationsRead,0]);
            
        }
        else
        {
            notificationText.text = "No more notifications at this time!";
        }
    }

    public void ignoreNotification()
    {
        if (notificationsRead == NOTIFICATION_NUMBER-1)
        {
            notificationsRead = -1;
            notifList.setNotifications(notifications);
        }
        notificationsQueued--;
        notificationsRead++;
        checkNotificationQueue();
    }

    public void TeacherEmail(int qCorrect)
    {
        switch (qCorrect)
        {
            case 1:
                var = " Bubbles ";
                break;
            case 2:
                var = " Dave ";
                break;
            case 3:
                var = " Wimbledon ";
                break;
            case 4:
                var = " Stabby ";
                break;
        }
        /*spawnComputerDistraction();
        spawnComputerDistraction();
        spawnComputerDistraction();*/    
        notifications[3,0] = "From: Professor Professorson\n Hello students!\nThis is just a reminder that in-class tomorrow we will be discussing the rise and fall of " + var + " \"Cincinnati Scoundrel\" Marks! Make sure you're ready to have a lively discussion.";
    }
    IEnumerator infightNotifications()
    {
        //enters after spawning the first notification
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
        yield return new WaitForSeconds(3);//causes a 3 second delay, use this between each notification spawn;
        spawnComputerDistraction();
        yield return new WaitForSeconds(5); //5 seconds before the next, so set them as you will.
        spawnComputerDistraction();
    }


}
