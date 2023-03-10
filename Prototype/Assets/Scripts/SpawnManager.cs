using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogsPrefabs;
    public float spawnRangeX = 10;
    public float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, dogsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(dogsPrefabs[animalIndex], spawnPos, dogsPrefabs[animalIndex].transform.rotation);
    }
}
