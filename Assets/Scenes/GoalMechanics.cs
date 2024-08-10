using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMechanics : MonoBehaviour
{

    private BallMovement ballScript;
    private UpdateScore scoreScript;
    public Rigidbody2D goal1;
    public Rigidbody2D goal2;


    // Start is called before the first frame update
    void Start()
    {
        ballScript = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMovement>();
        scoreScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<UpdateScore>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.otherRigidbody == goal1){
            scoreScript.UptickScoreOne();
            Debug.Log("goal1 hit");
        }
        else if(collision.otherRigidbody == goal2){
            scoreScript.UptickScoreTwo();
            Debug.Log("goal2 hit");
        }
        StartCoroutine(onCollision());
    }

    IEnumerator onCollision(){
        ballScript.ResetPosition();
        yield return new WaitForSeconds(3);
        ballScript.LaunchBall();
    }
}
