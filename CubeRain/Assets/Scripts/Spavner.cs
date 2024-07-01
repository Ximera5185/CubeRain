using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    [SerializeField] private Cube _cube;
    // [SerializeField] private Vector3 [] _spawnPointObject;
    private float minPositionX = -2f;
    private float maxPositionX = 1.4f;

    private float positionY = 15f;

    private float minPositionZ = -18f;
    private float maxPositionZ = 8f;

    private void Start()
    {
        //_cube = Instantiate(_cube,_spawnPointObject[Random.Range(0,_spawnPointObject.Length)],Quaternion.identity);
        _cube = Instantiate(_cube,new Vector3( Random.Range(-2,1.4f),15,Random.Range(-18,8)), Quaternion.identity);
    }
}
