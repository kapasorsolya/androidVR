using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
<<<<<<< HEAD
=======
    public float tileLength = 13f;
    public float spawnZ = 0f;
>>>>>>> dd7a90578e451fc92d17d36c28a32a343eb173c6

    private Transform playerTransform;
    private float spawnZ = 5.0f;
    private float tileLength = 12.6f;
    private float safeZone = 16.0f;
    private int amnTilesOnScreen = 7;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;

    private void Start()
    {
<<<<<<< HEAD
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            if (i < 2)
                SpawnTile(0);
            else 
                SpawnTile();
        }
        
=======
        //SpawnRoad();
        //cc//playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //cc//SpawnRoad();
        //cc//SpawnRoad();
        //cc//SpawnRoad();
>>>>>>> dd7a90578e451fc92d17d36c28a32a343eb173c6
    }

    private void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

<<<<<<< HEAD
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }

    private void DeleteTile(int prefabIndex = -1)
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1) return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
=======
    //cc//    public void SpawnRoad()
    //cc//    {
    //cc//      
    //cc//        //Instantiate(leftRoad, current.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    //cc//        GameObject go = Instantiate(tilePrefabs[0]) as GameObject;
    //cc//        go.transform.SetParent(transform);
    //cc//        go.transform.position = Vector3.forward * spawnZ;
    //cc//        spawnZ += tileLength;
    //cc//    }
>>>>>>> dd7a90578e451fc92d17d36c28a32a343eb173c6
}
