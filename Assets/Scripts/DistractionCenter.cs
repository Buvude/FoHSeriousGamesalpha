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
    public AudioClip SynthroidShort, SynthroidFull, dingSoud;
    public TextMeshProUGUI notificationText;
    public string[] notifications;
    public int notificationsQueued = 0, notificationsRead=0, totalNotificationsSpawned=0;
    public notificationList notifList;
    //public GameObject mentalChoices, phisichalChoices, computerChoices;
    // Start is called before the first frame update
    void Start()
    {
        //MentalDistractionSpawn();
        notifications = new string[20];
        notifList.setNotifications(notifications);
        for (int i = 0; i < 40; i++)
        {
            spawnComputerDistraction();
        }
        TeacherEmail(2);
        StartCoroutine("ComputerDistractionTime");
        StartCoroutine("MentalDistractionTime");
    }
    
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
        MentalDistraction.volume = 1f;
        MentalDistraction.clip=SynthroidShort;
        MentalDistraction.loop=false;
        MentalDistraction.Play();
        mentalDistractionHappening = true;
        //posterText.text = "Mental distractions will have many different forms, but for this demo we have an earworm, or a song that is stuck in your head. According to research a good way to deal with this is to listen to the song from start to end. In the full game, the longer that the song is stuck in your head, the harder it is to focus, and the more anxiety you will get, and the louder it will become.";
        //mentalChoices.SetActive(true);

    }
    public void mentatlDistractitonSynthroidFullSong()
    {
        MentalDistraction.volume = .1f;
        mentalDistractionHappening = false;
        MentalDistraction.clip = SynthroidFull;
        MentalDistraction.loop = false;
        MentalDistraction.Play();
        //mentalChoices.SetActive(false);
    }
    public void spawnPhysichalDistraction()
    {
        //TODO start conversation sound effect
        //posterText.text = "this will start a conversation that is distracting (probably a domestic dispute because it is distracting)";
    }

    public void spawnComputerDistraction()
    {
        //posterText.text = "This will cause a notification sound effect and add a notification to the notification queue (which you can then check, and dismiss notifications or read them (some need to be read, or else you might get a question wrong))";
        PhysichalDistraction.clip = dingSoud;
        PhysichalDistraction.loop = false;
        PhysichalDistraction.Play();
        notificationsQueued++;
        checkNotificationQueue();
    }

    public void checkNotificationQueue()
    {
        if (notificationsQueued > 0)
        {
            //TODO add 20 notifications and notification descriptions
            notificationText.text = (notifications[notificationsRead]);
        }
        else
        {
            notificationText.text = "No more notifications at this time!";
        }
    }

    public void ignoreNotification()
    {
        if (notificationsRead == 19)
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
        spawnComputerDistraction();
        if (notificationsRead < 19)
        {
            notifications[notificationsRead + 1] = "From: Professor Professorson\n Hello students!\nThis is just a reminder that in-class tomorrow we will be discussing the rise and fall of " + var + " \"Cincinnati Scoundrel\" Marks! Make sure you're ready to have a lively discussion.";
        }
        else
        {
            notifications[notificationsRead] = "From: Professor Professorson\n Hello students!\nThis is just a reminder that in-class tomorrow we will be discussing the rise and fall of " + var + " \"Cincinnati Scoundrel\" Marks! Make sure you're ready to have a lively discussion.";

        }

    }


}
