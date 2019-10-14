using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // gomb nyomasra mozog a kocka elore, hatra, jobbra, balra
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical") * Time.deltaTime); 
    }
}
