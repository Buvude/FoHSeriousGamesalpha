using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistractionCenter : MonoBehaviour
{
    public AudioSource ding;
    public AudioClip SynthroidShort, SynthroidFull, dingSoud;
    public TextMeshProUGUI posterText;
    //public GameObject mentalChoices, phisichalChoices, computerChoices;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator DistractionTime()
    {
        yield return new WaitForSeconds(1);
    }*/

    public void MentalDistractionSpawn()
    {
        ding.clip=SynthroidShort;
        ding.loop=true;
        ding.Play();
        posterText.text = "Mental distractions will have many different forms, but for this demo we have an earworm, or a song that is stuck in your head. According to research a good way to deal with this is to listen to the song from start to end. In the full game, the longer that the song is stuck in your head, the harder it is to focus, and the more anxiety you will get, and the louder it will become.";
        //mentalChoices.SetActive(true);

    }
    public void mentatlDistractitonSynthroidFullSong()
    {
        ding.clip = SynthroidFull;
        ding.loop = false;
        ding.Play();
        //mentalChoices.SetActive(false);
    }
}
