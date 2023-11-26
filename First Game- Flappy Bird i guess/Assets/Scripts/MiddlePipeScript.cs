using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{

    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();// we use this to connect with our logic script
        //first we need to find our object with this tag, and then get its component
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)//in unity the layer of our bird is 3, so this only checks if the bird has gone through the pipe(the collision)
        {
            logic.addScore();//here we just add score
        }       
    }
}
