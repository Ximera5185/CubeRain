using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private List<Cube> _poolCubes;
    [SerializeField] private Cube _cube;

    private int _amountToPool = 10;

    private void Awake()
    {
        _poolCubes = new List<Cube>();

        CreatePoolCubes();
    }

    public bool TryGetObject(out Cube cube)
    {
        for (int i = 0; i < _poolCubes.Count; i++)
        {
            if (_poolCubes [i].gameObject.activeSelf == false)
            {
                cube = _poolCubes [i];

                return true;
            }
        }

        cube = null;

        return false;
    }

    public void IncreasePool()
    {
        Cube cube = Instantiate(_cube);

        cube.gameObject.SetActive(false);

        _poolCubes.Add(cube);
    }

    private void CreatePoolCubes()
    {
        for (int i = 0; i < _amountToPool; i++)
        {
            IncreasePool();
        }
    }
}