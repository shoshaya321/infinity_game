using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{ 
     GameObject Player;
    public GameObject[] spawners;
    public GameObject prefabToSpawen;
    public float timer = 3f;
    public float timerToSpawn = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            CreatEnemy();
        }
        Vector3 spawnersPos =  new Vector3(0, Player.transform.position.y, Player.transform.position.z + 30f);
        transform.position = spawnersPos;
        
    }
    void CreatEnemy()
    {
        int randomSpawner = Random.Range(0, spawners.Length);
        Instantiate(prefabToSpawen, spawners[randomSpawner].transform.position, spawners[randomSpawner].transform.rotation);
        timer = timerToSpawn;
    }
}
