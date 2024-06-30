using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
   [SerializeField] private ColorGenerator _colorGenerator;

    private Material _material;
    private Color _defaultColor;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        _defaultColor = Color.black;

        _material.SetColor("_Color",_defaultColor); // ������������� ������� ����
        _material.SetColor("_EmissionColor", _defaultColor);
    }

    private void OnMouseDown()// �������� ���� �������� �� ��� ������ �� ������� ����� ������
    {
        Debug.Log("������");

        _material.SetColor("_Color", _colorGenerator.GetRandomCustomHDRColor());
        _material.SetColor("_EmissionColor", _colorGenerator.GetRandomCustomHDRColor()); 
    }
}