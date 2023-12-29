using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;//this is gonna make the ball go on the left or right
        float y = Random.Range(0, 2) == 0 ? -1 : 1;//this is gonna make the ball go up or down
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
