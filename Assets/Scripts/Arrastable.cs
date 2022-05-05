using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastable : MonoBehaviour {

    public bool isArrastrando = false;
    private Vector3 ratonPocicionInicalArerrastrado;
    private Vector3 imagenPocicionInicalArerrastrado;
    public bool isColliding;
    public GameObject colisionando;

    private void OnMouseDown() {
        isArrastrando = true;
        transform.SetParent(null);
        ratonPocicionInicalArerrastrado = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        imagenPocicionInicalArerrastrado = transform.localPosition;
    }

    private void OnMouseDrag() {
        if (isArrastrando) {
            transform.localPosition = imagenPocicionInicalArerrastrado + (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - ratonPocicionInicalArerrastrado;
        }
    }

    private void OnMouseUp() {
        isArrastrando = false;
        if(isColliding)
        {
            transform.position = colisionando.transform.position;
            transform.SetParent(colisionando.gameObject.transform);           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Snap")
        {
            isColliding = true;
            colisionando = collision.gameObject; 
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        isColliding = false;
    }

}
