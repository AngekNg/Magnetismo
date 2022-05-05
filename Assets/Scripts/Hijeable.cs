using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hijeable : MonoBehaviour
{
    Arrastable arrastrableScript;

    private void Start()
    {
        arrastrableScript = GetComponent<Arrastable>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Snap" && arrastrableScript.isArrastrando == false)
        {
            transform.SetParent(collision.gameObject.transform);
        }
    }
}
