using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Speech : MonoBehaviour
{
    public AudioSource thisSound;
    public AudioClip sound;
    public GameObject speechBubble;

    public int damageFactor = 5;
    public float speed = 5f;
    public int damage;

    void Start()
    {
       GetComponent<Rigidbody>().velocity = transform.forward * 50;
    }

    public abstract void LoadSound();

    public void PlaySound()
    {
        AudioSource.PlayClipAtPoint(thisSound.clip, transform.position, 1f);
    }

}
