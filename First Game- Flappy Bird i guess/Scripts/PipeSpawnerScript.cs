using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;//what we are going to spawn
    public float spawnTime = 2;// how often we should spawn it
    public float timer = 0; // count the time between free space (no spawn time)
    public float heightOffset = 10; // maximum height our game object can spawn
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); // immediantely after the start of the game spawn a pipe
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnTime)// while this is true we won't spawn pipes
        {
            timer = timer + Time.deltaTime;// add time every second
        }
        else//if our timer get higher than our spawn time, then its time to spawn a pipe and restart the timer
        {
            spawnPipe();
            timer = 0;
        }      
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;//lowest position our game object can spawn
        float highestPoint = transform.position.y + heightOffset;// highest position our game object can spawn
        //this spawns n-times whatever we tell it

        //in our case- spawn pipe,on the same width between them, on random height,infinity times
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
