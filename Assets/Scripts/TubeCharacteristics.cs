using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCharacteristics : MonoBehaviour
{
    [SerializeField]
    GameController1 gameManager;
    [SerializeField] Arrastable arrastroScript;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameController1>();
        transform.localScale *= gameManager.tubeSizeValue;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Trash" && arrastroScript.isArrastrando)
        Destroy(gameObject);
    }
}
