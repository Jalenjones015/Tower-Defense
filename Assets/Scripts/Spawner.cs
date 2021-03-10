using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] enemies;
    int randomspawnpoint, randommonster;
    public static bool spawnallowed;

    public void Start()
    {
        spawnallowed = true;
        InvokeRepeating("Spawn", 3f, 3f);
    }

    void Spawn()
    {
        if (spawnallowed)
        {
            randommonster = Random.Range(0, enemies.Length);
            Instantiate(enemies[randommonster], spawnpoints[randomspawnpoint].position, Quaternion.identity);
        }
    }
}
