using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Color _defaultColor;
    private bool _isCollided;
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        
    }

    private void Start()
    {
        _defaultColor = Color.black;

        _meshRenderer.material.SetColor("_Color",_defaultColor); // Устанавливаем простой цвет
        _meshRenderer.material.SetColor("_EmissionColor", _defaultColor);
    }
    public void SetColor(ColorGenerator colorGenerator)
    {
        /*_meshRenderer.material.SetColor("_Color", colorGenerator.GetRandomCustomHDRColor());
        _meshRenderer.material.SetColor("_EmissionColor", colorGenerator.GetRandomCustomHDRColor());*/
        _meshRenderer.material.color = Color.blue;
        
        Debug.Log("Попытались изменить цвет");
    }

    /* private void OnMouseDown()
     {
         _material.SetColor("_Color", _colorGenerator.GetRandomCustomHDRColor());
         _material.SetColor("_EmissionColor", _colorGenerator.GetRandomCustomHDRColor());
     }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (_isCollided == false)
        {
            _isCollided = true;
            
            Debug.Log("Ударился");
        }
        
    }
}