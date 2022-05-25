using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float minSpeed;
    [SerializeField] float maxSpeed;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (0,-1,0)*speed*Time.deltaTime);

        if(transform.position.y < -10)
        {
            //Destroy(gameObject);//
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "umbrella")
        {
            Debug.Log("PUSSY");
        }

        
    }
}
