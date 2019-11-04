using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int points = 0;
    private Rigidbody mRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //mRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }

    //private void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");
    //
    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //
    //    mRigidbody.AddForce(movement);
    //}
}
