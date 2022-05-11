using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCharacteristics : MonoBehaviour
{
    public TextMeshPro powerText;
    [SerializeField]
    GameController1 gameManager;
    [SerializeField]
    PointEffector2D mg;
    [SerializeField] 
    Arrastable arrastroScript;
    public float originalForce;
    public bool snapping;

    void Start()
    {
        mg = GetComponentInChildren<PointEffector2D>();
        gameManager = FindObjectOfType<GameController1>();
        transform.localScale *= gameManager.sizeValue;
        mg.forceMagnitude *= gameManager.powerValue;
        originalForce = mg.forceMagnitude;
        powerText.text = ""+gameManager.powerValue; 
    }

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

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Trash" && arrastroScript.isArrastrando)
        Destroy(gameObject);
    }
}
