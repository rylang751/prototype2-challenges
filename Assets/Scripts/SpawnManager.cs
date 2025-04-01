using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 3.0f;
    private float spawnInterval = 2.5f;
    private float xRange = 23;
    private float zRange = 25;
    public float moveSpeed = 5f; // Speed at which the animal moves
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
     public float sideSpawnX;

     void SpawnLeftAnimal()
    {
       int animalIndex = Random.Range(0, animalPrefabs.Length);
       Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
       Instantiate(animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
    
    void SpawnRightAnimal()
   {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
    Instantiate(animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
    }


    void SpawnRandomAnimal()
    {
       // Randomly generate a number between 0 and highest index in animalPrefabs array
        int randomAnimal = Random.Range(0, animalPrefabs.Length);
        // Randomly generate a spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange),0,zRange);

        //Spawn animals using the random index and randon X position    
        Instantiate(animalPrefabs[randomAnimal], spawnPos, animalPrefabs[randomAnimal].transform.rotation);
    }
}
