using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab; 
    [SerializeField] private float spawnDelay = 2f; 
    [SerializeField] private float spawnDistance = 0.45f; 

    private float timer; 

    private void Start()
    {
        timer = 0f;
        SpawnPipe();
    }

    private void Update()
    {
        if (timer >= spawnDelay)
        {
            SpawnPipe();
            timer = 0f;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0f, Random.Range(-spawnDistance, spawnDistance), 0f); 
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        Destroy(pipe, 5f);
    }
}
