using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 15;
    public float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position is the place where our game object spawns
        //Vector3.left tells us to go on left and * moveSpeed tells us how fast
        //Time.deltaTime - this means our action before this command will happen every second(frame)
        transform.position = transform.position + (Vector3.left *moveSpeed) * Time.deltaTime;        
        //if it goes too on the left - remove the game object
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);           
        }
    }   
}
