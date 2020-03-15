using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class User : MonoBehaviour
{
    int health;

    public void Damage(int damage)
    {
        health = Mathf.Max(0, health - damage);
        if(health == 0)
        {
            Die();
        }
    }
    // Start is called before the first frame update
    public void Move(Vector3 direction)
    {
        
    }

    // Update is called once per frame
    public abstract void Die();
}
