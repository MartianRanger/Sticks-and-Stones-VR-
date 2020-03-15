using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeechBubble : Speech //Different speech bubble type that is only used by enemies
{

    public void CreateSpeechBubble(AudioClip recording) //Was originally going to be Load Sound method, but didn't work with recordings. Stores recording into speech bubble.
    {
        thisSound = GetComponent<AudioSource>();
        thisSound.clip = recording;
        Debug.Log(thisSound.clip.length + " " + thisSound.clip.name);
        LoadDamage();

    }

    // Start is called before the first frame update
    public override void LoadSound()
    {

    }
    void OnCollisionEnter(Collision other) //Method is needed to determine whether or not it hits an enemy
    {
        PlaySound(); //Plays sound at an actual position, which will be whether it hits a collider
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyAI>().TakeDamage(damage);
            Debug.Log("Cloud: " + damage);

        }
        Destroy(gameObject); //Then object is destroyed

    }
}
