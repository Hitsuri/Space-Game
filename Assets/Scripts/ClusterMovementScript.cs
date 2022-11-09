using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterMovementScript : MonoBehaviour
{
	//default speed
    private float Defaultspeed = 0.15f;
	//speed as the game goes on
    private float difficultySpeed;
	//physics
    Rigidbody2D rb;
	//losing screen
    public GameObject youLose;


    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.15f, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(rb.velocity.y);
		
		//higher score increases the speed of asteroids
        difficultySpeed = Defaultspeed * (ScoreScript.score + 1);


		//asteroids move like in space invaders left to right and down
        if (rb.velocity.x > 0)
        {
            MoveRight(difficultySpeed);
        }
        if (rb.velocity.x < 0)
        {
            MoveLeft(difficultySpeed);
        }

        if (transform.position.x < -0.5f)
        {
            MoveRight(difficultySpeed);
        }

        if (transform.position.x > 2.75f)
        {
            MoveLeft(difficultySpeed);
        }

    }

	//movement right
    private void MoveRight(float speed)
    {
        rb.velocity = new Vector2(speed, -(speed/10) - 0.05f);
    }

	//movement left
    private void MoveLeft(float speed)
    {
        rb.velocity = new Vector2(-speed, -(speed/10) - 0.05f);
    }
	
	//reset to default location location
    private void ResetPosition()
    {
        transform.position = new Vector2(-0.4f, 5f);
    }

	//losing screen activation
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            youLose.SetActive(true);
        }
    }
}
