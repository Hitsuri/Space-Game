using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		//lifetime of particles is 2 seconds
        Destroy(gameObject, 2);
    }


}
