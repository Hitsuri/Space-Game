using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
	//player speed
    private float speed = 2f;
	//player physics
    Rigidbody2D rb;
	//player death effect
    public ParticleSystem deathParticles;
	//lose screen
    public GameObject youLose;
    
	// Start is called before the first frame update
	//centers the player and gets player's physics body
    private void Start()
    {
        ResetPosition();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

	//reads horizontal input and moves the player accordingly
    private void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * speed, 0);
    }

	//reset to default position
    private void ResetPosition()
    {
        transform.position = new Vector2(0, -3.75f);
    }

	//on hit gets the other object and if it's an asteroid: destroy the player and add death effects
    private void OnTriggerEnter2D(Collider2D other)
    {
        Asteroid asteroid = other.GetComponent<Asteroid>();

        if (asteroid != null)
        {
            Destroy(gameObject);
            Instantiate(deathParticles, new Vector3(transform.position.x, transform.position.y, 1) , Quaternion.identity);
            youLose.SetActive(true);
            Time.timeScale = 0.25f;
        }
    }

}
