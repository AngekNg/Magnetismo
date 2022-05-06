using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAtWorldPlace : MonoBehaviour
{
    [SerializeField] float xCoord,yCoord;
    [SerializeField] bool permaFix;
    Vector3 worldPos,screenPoint;
    Camera cam;
    float camScale;
    Vector3 originalScale;

    void Start(){
        cam = Camera.main;
        camScale =cam.orthographicSize/5;
        screenPoint = new Vector3 (xCoord, yCoord, 10);
        worldPos = cam.transform.position + (screenPoint);
        transform.position= cam.transform.position + screenPoint*camScale;;
        originalScale = transform.localScale;
    }

    void Update()
    {   
        if(permaFix){
        camScale =cam.orthographicSize/5;
        transform.position = cam.transform.position + screenPoint*camScale;
        transform.localScale =  originalScale * camScale;
        }

    }

}
