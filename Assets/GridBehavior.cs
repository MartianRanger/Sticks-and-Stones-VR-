using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehavior : MonoBehaviour
{
    public int gridX, gridZ;
    public GameObject prefab;
    public float gridOffset = 1f;

    void Start()
    {
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridOffset, 0, z * gridOffset);
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }

        }

    }
}