using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float minSpeed;
    [SerializeField] float maxSpeed;
    float speed;

    [SerializeField]  private GameObject Boss;
    public GameObject Enemyfall;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (0,-1,0)*speed*Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Umbrella")
        {
            Destroy(gameObject);
        }
        if (collisionInfo.collider.tag == "Ground")
        {
            Destroy(gameObject);
            Instantiate(Boss, transform.position = new Vector3(Enemyfall.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (collisionInfo.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
