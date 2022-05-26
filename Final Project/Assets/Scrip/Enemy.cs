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
    
   
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);      
    }

    void Update()
    {
        transform.Translate(new Vector3 (0,-1,0)*speed*Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Umbrella")
        {
            SoundManager.Playsound("WaterDrop");
            Destroy(gameObject);
           
            Instantiate(Boss, transform.position = new Vector3(Enemyfall.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (collisionInfo.collider.tag == "Ground")
        {
            SoundManager.Playsound("WaterDrop");
            Destroy(gameObject);
            
            Instantiate(Boss, transform.position = new Vector3(Enemyfall.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (collisionInfo.collider.tag == "Player")
        {
            SoundManager.Playsound("Yoshisound");
            Destroy(gameObject);
           
            Instantiate(Boss, transform.position = new Vector3(Enemyfall.transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
