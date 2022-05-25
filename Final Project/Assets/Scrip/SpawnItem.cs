using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] private Transform[] ItemSpawnPoint;
    [SerializeField] GameObject[] ItemInGame;
    float timebetwspawn = 0;


    void Start()
    {

    }


    void Update()
    {
        if (timebetwspawn <= 0)
        {
            int randomindex = Random.Range(0, ItemSpawnPoint.Length);
            Transform spawnPoint = ItemSpawnPoint[randomindex];
            randomindex = Random.Range(0, ItemInGame.Length);
            Instantiate(ItemInGame[randomindex], spawnPoint.position, Quaternion.identity);
            timebetwspawn = 10;
        }
        else
        {
            timebetwspawn -= Time.deltaTime;
        }
    }
}
