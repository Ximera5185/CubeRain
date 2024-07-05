using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public event Action<Cube> onTouched;

    private MeshRenderer _meshRenderer;
    private Color _defaultColor;
    private bool _isCollided;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    
  
    private void OnCollisionEnter(Collision collision)
    {
        if (_isCollided == false)
        {
            _isCollided = true;

            onTouched?.Invoke(this);

            Debug.Log("Ударился");
        }
    }

    public void SetColor(Color color)
    {
        _meshRenderer.material.SetColor("_Color", color);
        _meshRenderer.material.SetColor("_EmissionColor", color);
    }
}