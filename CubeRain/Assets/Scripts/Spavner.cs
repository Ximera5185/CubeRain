using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    [SerializeField] private ObjectPool _cubePool;
    [SerializeField] private ColorGenerator _colorGenerator;

    private MeshRenderer _renderer;

    private float minPositionX = -2f;
    private float maxPositionX = 1.4f;

    private float positionY = 15f;

    private float minPositionZ = -18f;
    private float maxPositionZ = 8f;

    private void Update()
    {
        SpawnCubes();
    }

    public void SpawnCubes() 
    {
        if (_cubePool.TryGetObject(out Cube cube))
        {
            cube.transform.position = new Vector3(Random.Range(minPositionX, maxPositionX), positionY, Random.Range(minPositionZ, maxPositionZ));
            cube.gameObject.SetActive(true);
            cube.SetColor(_colorGenerator.GetRandomCustomHDRColor());
            

           /* _renderer.material.SetColor("_Color", _colorGenerator.GetRandomCustomHDRColor());
            _renderer.material.SetColor("_EmissionColor", _colorGenerator.GetRandomCustomHDRColor());*/
            //_renderer.material.color = Color.white;
           // cube.SetColor(_colorGenerator);
        }
    }
}
