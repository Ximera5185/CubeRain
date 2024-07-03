using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Color _defaultColor;
    private bool _isCollided;
    /*private ColorGenerator _colorGenirator;*/
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        
    }

    
    public void SetColor(Color color)
    {
        
        //_meshRenderer.material.color= color;
        _meshRenderer.material.SetColor("_Color", color);
        _meshRenderer.material.SetColor("_EmissionColor", color);
        //_meshRenderer.material.color = color;

        Debug.Log("Попытались изменить цвет");
    }
   /* public void Init(ColorGenerator colorGenerator) 
    {
        _colorGenirator = colorGenerator;
    }*/
   /* private void OnMouseDown()
    {
        _meshRenderer.material.SetColor("_Color", _colorGenirator.GetRandomCustomHDRColor());
        _meshRenderer.material.SetColor("_EmissionColor", _colorGenirator.GetRandomCustomHDRColor());
       // _meshRenderer.material.emis
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