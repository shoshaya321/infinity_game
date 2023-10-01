using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    GameObject Player;
  
    float spawnZ = 30f;
    float tileLength = 15f;
    int tileAmountOnScreen = 5;
    public GameObject[] tiles;
    public List<GameObject> spawnedTiles;
    float safeZone = 30f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        for (int i = 0; i < tileAmountOnScreen; i++)
        {
            SpawnTiels(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.z - safeZone > (spawnZ - tileAmountOnScreen * tileLength))
        {
            SpawnTiels(0);
            DestroyTiels();
        }
        
        
    }

    void SpawnTiels(int index)
    {
        int randomTile = Random.Range(1, tiles.Length);
        if (index == 0)
        { 
         randomTile = 0;
        
        }
        Vector3 tilePos = new Vector3(Player.transform.position.x, 0 , spawnZ);
       GameObject tile = Instantiate(tiles[randomTile], tilePos, tiles[randomTile].transform.rotation);
        spawnZ += tileLength;
        spawnedTiles.Add(tile);

    }
     void DestroyTiels()
    {
        Destroy(spawnedTiles[0]);
        spawnedTiles.RemoveAt(0);
    }
}
