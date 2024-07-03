using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{
    [SerializeField] private List<Material> _materials;

    public Material GetRandomCustomHDRColor()
    {
        return _materials [Random.Range(0, _materials.Count)];
    }
}