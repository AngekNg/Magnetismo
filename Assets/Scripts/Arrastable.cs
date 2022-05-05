using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastable : MonoBehaviour {

    //public delegate void ArrastroFinalDelegate(Arrastable objetoArrastable);

    //public ArrastroFinalDelegate arrastroFinalLlamadodevuelta;

    public bool isArrastrando = false;
    private Vector3 ratonPocicionInicalArerrastrado;
    private Vector3 imagenPocicionInicalArerrastrado;

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
        //arrastroFinalLlamadodevuelta(this);
    }


}
