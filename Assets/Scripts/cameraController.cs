using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    Camera cam;
    [SerializeField]float cameraSpeed = 1;
    private void Start() {
        cam = GetComponent<Camera>();
    }
 
    void Update () {
        cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel")*2f;
        if(cam.orthographicSize>10)
        cam.orthographicSize = 10;
        if (cam.orthographicSize < 1)
            cam.orthographicSize = 1;
        cameraMovement();
    }
    void cameraMovement(){
        transform.position = new Vector3(transform.position.x+Input.GetAxis("Horizontal")*cameraSpeed*cam.orthographicSize*Time.deltaTime,transform.position.y + Input.GetAxis("Vertical")*cameraSpeed*cam.orthographicSize*Time.deltaTime,-10);
    }

}
