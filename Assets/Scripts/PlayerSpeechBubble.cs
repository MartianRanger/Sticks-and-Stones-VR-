using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeechBubble : Speech
{

    public void CreateSpeechBubble(AudioClip recording)
    {
        thisSound = GetComponent<AudioSource>();
        thisSound.clip = recording;
        Debug.Log(thisSound.clip.length + " " + thisSound.clip.name);
        thisSound.Play();
        PlaySound();
        LoadDamage();

    }
    public void LoadDamage()
    {
        damage = (int)(damageFactor * thisSound.clip.length);
        Debug.Log("DAMGE!" + damageFactor);
    }

    // Start is called before the first frame update
    public override void LoadSound()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        PlaySound();
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyAI>().TakeDamage(damage);
            Debug.Log("Cloud: " + damage);

        }
    }
}
