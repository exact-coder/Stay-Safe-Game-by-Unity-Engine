using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float enemySpawnDelay;
    private float currentTime;
    private float lastSpawnedTime;
    // Start is called before the first frame update
    void Start()
    {
        lastSpawnedTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
        if(currentTime - lastSpawnedTime >= enemySpawnDelay){
            SpawnEnemy();
        }



        
    }

    void SpawnEnemy(){
        float posX = 9.1f;
        float posY = Random.Range(-4.2f,4.2f);

        Vector2 pos = new Vector2(posX,posY);
        Instantiate(enemyPrefab,pos,Quaternion.identity);

        lastSpawnedTime = Time.time;

    }
}
