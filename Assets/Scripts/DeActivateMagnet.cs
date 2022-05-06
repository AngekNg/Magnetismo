using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateMagnet : MonoBehaviour
{
    [SerializeField]
    PointEffector2D mg;
    public float originalForce;
    public bool snapping;

    // Start is called before the first frame update
    void Start()
    {
        mg = GetComponentInChildren<PointEffector2D>();
        originalForce = mg.forceMagnitude;
    }

    // Update is called once per frame
    void Update()
    {
        if (snapping)
        reduceMagnitude();
        else if (mg.forceMagnitude != originalForce)
        enhanceMagnitude();
    }

    void reduceMagnitude()
    {
        mg.forceMagnitude = Mathf.Lerp(mg.forceMagnitude,0f,0.02f);
    }

    void enhanceMagnitude()
    {
        mg.forceMagnitude = originalForce;
    }

    void OnTriggerEnter2D()
    {
        snapping = true;
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        snapping = false;
    }
}
