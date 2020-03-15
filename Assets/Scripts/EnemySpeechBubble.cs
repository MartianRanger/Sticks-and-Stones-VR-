using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeechBubble : Speech
{
    public AudioClip[] myClips;

    // Start is called before the first frame update
    void Awake()
    {
        LoadSound();
    }

    public override void LoadSound()
    {
        myClips = Resources.LoadAll<AudioClip>("Audio");
        thisSound = GetComponent<AudioSource>();
        RandomizeSfx(myClips);
        LoadDamage();
    }

    public void LoadDamage()
    {
        damage = (int)(damageFactor * thisSound.clip.length);
        Debug.Log("DAMGE!" + damageFactor);
    }
    public void RandomizeSfx(params AudioClip[] myClips)
    {
        //Generate a random number between 0 and the length of our array of clips passed in.
        int randomIndex = Random.Range(0, myClips.Length);

        //Set the clip to the clip at our randomly chosen index.
        thisSound.clip = myClips[randomIndex];
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        PlaySound();
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CustomVRControls>().TakeDamage(damage);
            Debug.Log("Cloud: " + damage);
        }
    }
}