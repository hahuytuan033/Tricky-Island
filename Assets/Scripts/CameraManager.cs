using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            mainCamera.transform.position = new Vector3(16.42f, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }    
    }
}
