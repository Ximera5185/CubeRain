using System.Collections;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    [SerializeField] private ObjectPool _cubePool;
    [SerializeField] private ColorGenerator _colorGenerator;

    private Coroutine _currentCoroutine;
    private WaitForSeconds _waitForSeconds;
    private float _timeSpawn = 0.1f;
    private float minPositionX = -2f;
    private float maxPositionX = 1.4f;
    private float positionY = 15f;
    private float minPositionZ = -14f;
    private float maxPositionZ = 8f;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_timeSpawn);
    }

    private void Start()
    {
        _currentCoroutine = StartCoroutine(Counting());
    }

    public void SpawnCubes()
    {
        if (_cubePool.TryGetObject(out Cube cube))
        {
            cube.transform.position = new Vector3(Random.Range(minPositionX, maxPositionX), positionY, Random.Range(minPositionZ, maxPositionZ));

            cube.gameObject.SetActive(true);
        }
        else
        {
            _cubePool.IncreasePool();
        }
    }

    private IEnumerator Counting()
    {
        while (true)
        {
            SpawnCubes();

            yield return _waitForSeconds;
        }
    }
}