using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private List<Cube> _poolCubes;
    [SerializeField] private int _amountToPool = 20;
    [SerializeField] private Cube _cube;

    private void Start()
    {
        _poolCubes = new List<Cube>();

        for (int i = 0; i < _amountToPool; i++)
        {
            Cube cube = Instantiate(_cube);

            cube.gameObject.SetActive(false);

            _poolCubes.Add(cube);
        }
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
}