using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController1 : MonoBehaviour
{
    public float powerValue=1, sizeValue=1, tubeSizeValue=1;
    [SerializeField]
    Slider powerSlider, sizeSlider,tubeSizeSlider;
    [SerializeField]
    TextMeshProUGUI powerText, sizeText,tubeSizeText;
    [SerializeField]
    GameObject magnetPrefab,tubePrefab;

    public void refreshData(){
        powerValue = Mathf.Round(powerSlider.value*100f)/100f;
        sizeValue = Mathf.Round(sizeSlider.value*100f)/100f;
        tubeSizeValue = Mathf.Round(tubeSizeSlider.value*100)/100f;
        powerText.text = "Potencia: "+powerValue;
        sizeText.text = "Tamaño: "+sizeValue;
        tubeSizeText.text ="Tamaño: "+tubeSizeValue;
    }

    public void spawnMagnet(){
        Instantiate (magnetPrefab);
    }

    public void spawnTube(){
        Instantiate (tubePrefab);
    }

    public void PowerOn(){
        var Forces = FindObjectsOfType<CircleCollider2D>();
        foreach (CircleCollider2D circle in Forces){
            if(circle.gameObject.tag != "Player")
            circle.enabled = true;
        }
        var circleSprite = FindObjectsOfType<SpriteRenderer>();
        foreach(SpriteRenderer esprait in circleSprite){
            if(esprait.gameObject.tag == "Radius")
            esprait.enabled = false;
        }
    }

    public void PowerOff(){
        var Forces = GameObject.FindObjectsOfType<CircleCollider2D>();
        foreach (CircleCollider2D circle in Forces){
            if(circle.gameObject.tag != "Player")
            circle.enabled = false;
        }
        var circleSprite = FindObjectsOfType<SpriteRenderer>();
        foreach(SpriteRenderer esprait in circleSprite){
            if(esprait.gameObject.tag == "Radius")
            esprait.enabled = true;
        }
        GameObject.Find("Ballin").GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
        //GameObject.Find("Ballin").GetComponent<Rigidbody2D>().velocity=Vector2.Lerp(GameObject.Find("Ballin").GetComponent<Rigidbody2D>().velocity,new Vector2(0,0),0.5f);
    }

    public void ResetScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
