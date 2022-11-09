using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	//audiosources for sounds
    public AudioSource gun;
    public AudioSource explosion;

	//soundmanager singleton instance
    public static SoundManager instance = null;

	//initialize singleton instance
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

	//shooting sound
    public void PlayGun(AudioClip clip)
    {
        gun.PlayOneShot(clip);
    }

	//explosion sound
    public void PlayExplosion(AudioClip clip)
    {
        explosion.PlayOneShot(clip);
    }

}
