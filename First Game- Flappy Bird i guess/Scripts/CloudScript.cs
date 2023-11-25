using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public ParticleSystem clouds;
    public float spawnTime = 2;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)// while this is true we won't spawn pipes
        {
            timer = timer + Time.deltaTime;// add time every second
        }
        else//if our timer get higher than our spawn time, then its time to spawn a pipe and restart the timer
        {
            Instantiate(clouds, transform.position, transform.rotation);
            timer = 0;
        }
        
    }
}
