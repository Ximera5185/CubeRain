using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Cube : MonoBehaviour
{
    private float _cubeLifetime = 5f;
    private MeshRenderer _meshRenderer;

    private Coroutine _currentCoroutine;
    private WaitForSeconds _waitForSeconds;


    [SerializeField] private Color _defaultColor;
    private bool _isCollided;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _waitForSeconds = new WaitForSeconds(_cubeLifetime);
    }

    private void OnEnable()
    {
        _currentCoroutine = StartCoroutine(Counting());
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (_isCollided == false && collision.gameObject.TryGetComponent<Platform>(out Platform platform))// 
        {
            _isCollided = true;

            SetColor(platform.GetColor());
            // onTouched?.Invoke(this);
        }
    }

    private IEnumerator Counting()
    {

        yield return _waitForSeconds;


        gameObject.SetActive(false);

        _isCollided = false;

        SetColor(_defaultColor);

    }

    public void SetColor(Color color)
    {
        _meshRenderer.material.SetColor("_Color", color);
        _meshRenderer.material.SetColor("_EmissionColor", color);
    }
}