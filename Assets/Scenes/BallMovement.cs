using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void LaunchBall(){
        float x = Random.value < 0.5f ? -1 : 1;
        float y  = Random.Range(-0.5f,0.5f);
        Vector2 direction = new Vector2(x,y).normalized;
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Ball contact");
        rb.velocity = rb.velocity * 1.1f;
    }

    public void ResetPosition(){
        rb.position = new Vector2(0,0);
        rb.velocity = new Vector2(0,0);
    }
}
