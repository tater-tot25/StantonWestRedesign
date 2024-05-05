using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    //this script allows the user to cycle through camera angles by disables all cameras
    //and keeping an index of the current camera, which becomes enabled
    public Camera[] cameraList;
    private int currentCamera = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Camera cam in cameraList) //disable all cameras
        {
            cam.enabled = false;
        }
        cameraList[currentCamera].enabled = true; //enable the first camera
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (currentCamera < cameraList.Length - 1) //go to next camera in feed
            {
                cameraList[currentCamera].enabled = false;
                currentCamera++;
                cameraList[currentCamera].enabled = true;
            }
            else //cycle back to first camera
            {
                cameraList[currentCamera].enabled = false;
                currentCamera = 0;
                cameraList[currentCamera].enabled = true;
            }
        }   
    }
}
