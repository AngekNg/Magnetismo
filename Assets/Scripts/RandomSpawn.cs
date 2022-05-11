using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    [SerializeField] Camera _camara;
    [SerializeField] int _offsetX;
    [SerializeField] int _offsetY;
    [SerializeField] GameObject _spawnedObject;

    int _randomX;
    int _randomY;

    public void Spawn() {
        Vector2 position = GetRandomCoordenates();
        _spawnedObject = Instantiate(_spawnedObject, position, Quaternion.identity) as GameObject;
    }

    Vector2 GetRandomCoordenates() {
        _randomX = Random.Range(0 + _offsetX, Screen.width - _offsetY);
        _randomY = Random.Range(0 + _offsetY, Screen.height - _offsetY);

        Vector2 coordinates = new Vector2(_randomX, _randomY);
        
        Vector2 screenToWolrdPosition = _camara.ScreenToWorldPoint(coordinates);

        return screenToWolrdPosition;
    }
}
