using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    //    public GameObject leftRoad;
    //    public GameObject current;
    public Transform playerTransform;
    public GameObject[] tilePrefabs;
    public float tileLength = 13f;
    public float spawnZ = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRoad();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        SpawnRoad();
        SpawnRoad();
        SpawnRoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRoad()
    {
      
        //Instantiate(leftRoad, current.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
        GameObject go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
