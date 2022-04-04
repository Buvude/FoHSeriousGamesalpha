using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistractionCenter : MonoBehaviour
{
    public AudioSource ding;
    public AudioClip SynthroidShort, SynthroidFull, dingSoud;
    public GameObject mentalChoices, phisichalChoices, computerChoices;
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
        mentalChoices.SetActive(true);

    }
    public void mentatlDistractitonsFullSong()
    {
        ding.clip = SynthroidFull;
        ding.loop = false;
        ding.Play();
        mentalChoices.SetActive(false);
    }
}
