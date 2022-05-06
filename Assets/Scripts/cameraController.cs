using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    Camera cam;
    [SerializeField]int cameraSpeed = 5;
    private void Start() {
        cam = GetComponent<Camera>();
    }
 
    void Update () {
        cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        cameraMovement();
    }
    void cameraMovement(){
        transform.position = new Vector3(transform.position.x+Input.GetAxis("Horizontal")*cameraSpeed*Time.deltaTime,transform.position.y + Input.GetAxis("Vertical")*cameraSpeed*Time.deltaTime,-10);
    }

}
