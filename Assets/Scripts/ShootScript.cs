using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
	//location where bullets spawn
    public Transform shootingPoint;
    public GameObject bullet;
	//sound for shooting
    public AudioClip gunshot;

	//if fire is pressed, shoots a bullet and plays a sound
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
            SoundManager.instance.PlayGun(gunshot);
        }
    }
	
	//spawns a bullet
    private void ShootBullet()
    {
        Instantiate(bullet, shootingPoint.position , Quaternion.identity);
    }
}
