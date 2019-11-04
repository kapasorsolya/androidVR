using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;
    private GameObject cameraContainer;
    private Quaternion rot;

    void Start()
    {
        //cc//cameraContainer = new GameObject("Camera Container");
        //cc//cameraContainer.transform.position = transform.position;
        //cc//transform.SetParent(cameraContainer.transform);
        //cc//gyroEnabled = EnableGyro();  
    }

    void Update()
    {
        if (gyroEnabled)
        {
            //Move camera as device rotates:
            //cc// transform.localRotation = gyro.attitude * rot;
        }
    }

    //cc//private bool EnableGyro()
    //cc//{
    //cc//    if(SystemInfo.supportsGyroscope)
    //cc//    {
    //cc//        gyro = Input.gyro;
    //cc//        gyro.enabled = true;
    //cc//        
    //cc//        cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
    //cc//        rot = new Quaternion(0, 0, 1, 0);
    //cc//
    //cc//        return true;
    //cc//    }
    //cc//    return false;
    //cc//}
}
