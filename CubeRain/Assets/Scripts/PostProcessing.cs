using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessing : MonoBehaviour
{
    private Material _material;
    private Color _newColor;
    private Color _defaultColor;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        _defaultColor = Color.black;
        _material.SetColor("_Color",_defaultColor); // Устанавливаем простой цвет
    }
    private void OnMouseDown()// Работает если нажимаем на тот объект на котором висит скрипт
    {
        Debug.Log("Нажали");

        _newColor = Color.red; // инициализируем

        _material.SetColor("_Color", _newColor); // Устанавливаем простой цвет
        _material.SetColor("_EmissionColor", _newColor); // Устанавливаем HDR цвет 
    }
}