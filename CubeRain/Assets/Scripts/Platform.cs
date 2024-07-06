using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
   [SerializeField] private ColorGenerator _colorGenerator;

    private MeshRenderer _meshRenderer;
    private WaitForSeconds _waitForSeconds;
    private Coroutine _currentCoroutine;
    private float _time—olor—hange = 1f;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _waitForSeconds = new WaitForSeconds(_time—olor—hange);
    }

    private void Start()
    {
        _currentCoroutine = StartCoroutine(Counting());
    }

    public Color GetColor() 
    {
        return _meshRenderer.material.color;
    }

    private void SetColor(Color color) 
    {
        _meshRenderer.material.SetColor("_Color", color);
        _meshRenderer.material.SetColor("_EmissionColor", color);
    }

    private IEnumerator Counting()
    {
        while (true)
        {
            Color color = _colorGenerator.GetRandomCustomHDRColor().color;
            SetColor(color);

            yield return _waitForSeconds;
        }
    }
}
