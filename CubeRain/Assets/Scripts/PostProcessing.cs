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
        _material.SetColor("_Color",_defaultColor); // ������������� ������� ����
    }
    private void OnMouseDown()// �������� ���� �������� �� ��� ������ �� ������� ����� ������
    {
        Debug.Log("������");

        _newColor = Color.red; // ��������������

        _material.SetColor("_Color", _newColor); // ������������� ������� ����
        _material.SetColor("_EmissionColor", _newColor); // ������������� HDR ���� 
    }
}