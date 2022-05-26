using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlekill : MonoBehaviour
{
    float timecount;

    void Start()
    {
        
    }

   
    void Update()
    {
        destroyparticle();
    }

    void destroyparticle()
    {
        timecount = timecount + Time.deltaTime;
        if (timecount >= 2)
        {
            Destroy(gameObject);    
        }
    }
}
