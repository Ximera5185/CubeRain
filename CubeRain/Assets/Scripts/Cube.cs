using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Material _material;
    private Color _defaultColor;
    private bool _isCollided;
    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
        
    }

    private void Start()
    {
        _defaultColor = Color.black;

        _material.SetColor("_Color",_defaultColor); // Устанавливаем простой цвет
        _material.SetColor("_EmissionColor", _defaultColor);
    }
    public void SetColor(ColorGenerator colorGenerator)
    {
        /*_material.SetColor("_Color", colorGenerator.GetRandomCustomHDRColor());
        _material.SetColor("_EmissionColor", colorGenerator.GetRandomCustomHDRColor());*/

        _material.color = Color.red;
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