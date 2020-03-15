using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAroundPlayer : MonoBehaviour
{
    public float speed;
    public Vector3 originPoint;
    public int randomFactor;
    // Start is called before the first frame update
    void Start()
    {
        originPoint = new Vector3(-2.0f, 0.0f, -5.0f);
        speed = Random.Range(5, 10);
        randomFactor = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (randomFactor < 5 && randomFactor > 1)
        {
            transform.RotateAround(originPoint, Vector3.up, speed * Time.deltaTime);

        }
        else
        {
            transform.RotateAround(originPoint, Vector3.down, speed * Time.deltaTime);

        }
    }
}
