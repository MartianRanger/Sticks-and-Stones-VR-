using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawn : MonoBehaviour
{
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        instantiateInCircle(prefab, transform.position, 20);
    }

    public void instantiateInCircle(GameObject obj, Vector3 location, int howMany)
    {
        for (int i = 0; i < howMany; i++)
        {
            float radius = howMany;
            float angle = i * Mathf.PI * 2f / radius;
            Vector3 newPos = transform.position + (new Vector3(Mathf.Cos(angle) * radius, -2, Mathf.Sin(angle) * radius));
            var newPlatform = Instantiate(obj, newPos, Quaternion.Euler(0, 0, 0));
            newPlatform.transform.parent = transform;
        }
    }

}
