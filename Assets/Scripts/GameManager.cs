using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   public int score =0;
    public int lives = 3;
    public GameObject animalPrefab; // Reference to the animal prefab
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeY = 5f; // Range for vertical spawn position

    // Start is called before the first frame update
     private void Start()
    {
        InvokeRepeating("SpawnAnimal", 0f, spawnInterval);

    }

    void SpawnAnimal()
    {
         // Randomly choose left or right side of the screen for spawning
        float spawnX = Random.Range(-Screen.width / 2, Screen.width / 2);
        Vector3 spawnPosition = new Vector3(spawnX, Random.Range(-spawnRangeY, spawnRangeY), 0f);
        spawnPosition = Camera.main.ScreenToWorldPoint(spawnPosition); // Convert to world position

        // Instantiate the animal at the chosen position
        Instantiate(animalPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    public void AddScore(int value)
    {
       score += value;
       Debug.Log("Score: " + score);
    }
}    
 