using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -15;
    private float sideBound = 30;
     private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //if an object goes pasr the players view in the game, remove that object
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {   
           // gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x <-sideBound)
        {
          // gameManager.AddLives(-1);
           Destroy(gameObject);
        }
    }
}
