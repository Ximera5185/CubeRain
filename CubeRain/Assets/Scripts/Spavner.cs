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
        Cube cube = Instantiate(_cube, new Vector3(Random.Range(minPositionX, maxPositionX), positionY, Random.Range(minPositionZ, maxPositionZ)), Quaternion.identity);
    }
}
