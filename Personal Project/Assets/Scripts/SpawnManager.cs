using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject plasticPrefab;
    public float spawnRange = 60;
    private float startDelay = 2;
    public float spawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlastic", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnPlastic()
    {
        Instantiate(plasticPrefab, GenerateSpawnPosition(), plasticPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange); // x range for plastic spawn
        float spawnPosZ = Random.Range(-spawnRange, spawnRange); // z range for plastic spawn
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
