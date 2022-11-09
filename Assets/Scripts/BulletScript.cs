using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
	//speed
    public float speed = 10f;
	//physics
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 1f);
    }

	//gets the object the bullet hit and calls the damage function if it's an asteroid and destroys the bullet
    private void OnTriggerEnter2D(Collider2D other)
    {
        Asteroid asteroid = other.GetComponent<Asteroid>();

        if (asteroid != null)
        {
            asteroid.TakeHit();
        }

        Destroy(gameObject);
    }
}
