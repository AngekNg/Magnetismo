using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour {

    public List<Transform> puntosAcople;
    public List<Arrastable> objetosArrastables;
    public float rangoAcople = 0.5f;
    
    // Start is called before the first frame update
    void Start() {
        foreach (Arrastable arrastable in objetosArrastables) {
            //arrastable.arrastroFinalLlamadodevuelta = CuandoTermineArrastrado;
        }
    }

    private void CuandoTermineArrastrado(Arrastable arrastable) {
        float distanciaCercana = -1;
        Transform puntoAcopleCercano = null;

        foreach(Transform puntoAcople in puntosAcople) {
            float distanciaActual=Vector2.Distance(arrastable.transform.localPosition, puntoAcople.localPosition);
            if (puntoAcopleCercano == null || distanciaActual < distanciaCercana) {
                puntoAcopleCercano = puntoAcople;
                distanciaCercana = distanciaActual;
            }
        }
        
        if (puntoAcopleCercano != null && distanciaCercana <= rangoAcople) {
            arrastable.transform.localPosition = puntoAcopleCercano.localPosition;            
        }
    }
}
