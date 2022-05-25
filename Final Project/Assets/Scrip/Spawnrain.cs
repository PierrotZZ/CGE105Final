using UnityEngine;

public class Spawnrain : MonoBehaviour 
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] GameObject[] enemy;
    float timebetwspawn = 0;
    
    
    void Start()
    {
          
    }

   
    void Update()
    {
        if (timebetwspawn <= 0)
        {
            int randomindex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[randomindex];
            randomindex = Random.Range(0, enemy.Length);    
            Instantiate(enemy[randomindex], spawnPoint.position, Quaternion.identity);
            timebetwspawn = 1;
        }
        else
        {
            timebetwspawn -= Time.deltaTime;
        }       
    }

}
