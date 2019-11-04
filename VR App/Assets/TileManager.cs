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
    public float spawnZ = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRoad();
        //cc//playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //cc//SpawnRoad();
        //cc//SpawnRoad();
        //cc//SpawnRoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //cc//    public void SpawnRoad()
    //cc//    {
    //cc//      
    //cc//        //Instantiate(leftRoad, current.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    //cc//        GameObject go = Instantiate(tilePrefabs[0]) as GameObject;
    //cc//        go.transform.SetParent(transform);
    //cc//        go.transform.position = Vector3.forward * spawnZ;
    //cc//        spawnZ += tileLength;
    //cc//    }
}
