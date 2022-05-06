using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    [SerializeField] GameObject[] _objs;
    [SerializeField] Camera _camara;
    [SerializeField] int _offsetX;
    [SerializeField] int _offsetY;

    GameObject _spawnedObject;

    int _randomX;
    int _randomY;
    
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Spawn();
        }
    }

    void Spawn() {
        int randomObjectID = Random.Range(0, _objs.Length);
        Vector2 position = GetRandomCoordenates();

        _spawnedObject = Instantiate(_objs[randomObjectID], position, Quaternion.identity) as GameObject;
    }

    Vector2 GetRandomCoordenates() {
        _randomX = Random.Range(0 + _offsetX, Screen.width - _offsetY);
        _randomY = Random.Range(0 + _offsetY, Screen.height - _offsetY);

        Vector2 coordinates = new Vector2(_randomX, _randomY);
        
        Vector2 screenToWolrdPosition = _camara.ScreenToWorldPoint(coordinates);

        return screenToWolrdPosition;
    }
}
