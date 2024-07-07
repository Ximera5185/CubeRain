using System.Collections;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    [SerializeField] private ObjectPool _cubePool;
    [SerializeField] private ColorGenerator _colorGenerator;

    private WaitForSeconds _waitForSeconds;

    private float _timeSpawn = 0.4f;
    private float _minPositionX = -2f;
    private float _maxPositionX = 1.4f;
    private float _positionY = 23f;
    private float _minPositionZ = -10f;
    private float _maxPositionZ = 12f;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_timeSpawn);
    }

    private void Start()
    {
        StartCoroutine(Counting());
    }

    public void SpawnCubes()
    {
        if (_cubePool.TryGetObject(out Cube cube))
        {
            cube.transform.position = new Vector3(Random.Range(_minPositionX, _maxPositionX), _positionY, Random.Range(_minPositionZ, _maxPositionZ));

            cube.gameObject.SetActive(true);
        }
        else
        {
            _cubePool.IncreasePool();
        }
    }

    private IEnumerator Counting()
    {
        while (enabled)
        {
            SpawnCubes();

            yield return _waitForSeconds;
        }
    }
}