using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] cameraManage;
    void Start()
    {
        
    }

    void Update()
    {
        Camaras();
    }

    void Camaras()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            cameraManage[0].SetActive(true);
            cameraManage[1].SetActive(false);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            cameraManage[0].SetActive(false);
            cameraManage[1].SetActive(true);
        }
    }
}
