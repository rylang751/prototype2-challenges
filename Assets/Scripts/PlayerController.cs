using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    public float xRange = 10;
    public float speed = 15;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float moveSpeed = 5f; // Speed at which the player moves
    void Update()
    {   
        Instantiate(projectilePrefab, projectileSpawnPoint.position,projectilePrefab.transform.rotation);

        // Get input for moving forward (W or Up Arrow) and backward (S or Down Arrow)
        float moveDirection = Input.GetAxis("Vertical");

        // Move the player in the forward/backward direction
        transform.Translate(Vector3.forward * moveDirection * moveSpeed * Time.deltaTime);
    
        // Get the player's horizontal Input
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the player on the x-axis using horizontal input
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // Keep the player at -xRange when going left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Keep the player at xRange when going right
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Check if the player is pressing Spacebar
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
