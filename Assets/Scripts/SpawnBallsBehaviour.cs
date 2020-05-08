using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallsBehaviour : MonoBehaviour
{
    /**
     * The ball's game object that will be spawning in.
    **/
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        /**
        * Once the player click the sceen, a ball will spawn. 
        **/
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBall();
        }
    }

    /**
     * The spawner function to spawn in balls.
    **/
    void SpawnBall()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject spawnBall = Instantiate(ball, newPos, transform.rotation);
    }

}
