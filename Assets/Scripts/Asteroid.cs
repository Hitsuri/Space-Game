using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
	//death effect
    public ParticleSystem destroyEffect;
	//health
    public int health = 1;
	//death sound
    public AudioClip explosion;

	//asteroid takes damage
    public void TakeHit()
    {
        health -= 1;

        if (health <= 0)
        {
            Die();
        }
    }

	//kills the asteroid
    void Die()
    {
        Destroy(gameObject);
        SoundManager.instance.PlayGun(explosion);
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        ScoreScript.score++;
    }
}
