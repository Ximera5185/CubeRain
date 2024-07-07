using Assets.Scripts;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class Cube : MonoBehaviour
{
    [SerializeField] private Color _defaultColor;

    private MeshRenderer _meshRenderer;
    private WaitForSeconds _waitForSeconds;
    private float _cubeLifetime = 5f;
    private bool _isCollided;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _waitForSeconds = new WaitForSeconds(_cubeLifetime);
    }

    private void OnEnable()
    {
        StartCoroutine(Counting());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_isCollided == false && collision.gameObject.TryGetComponent<Platform>(out Platform platform))
        {
            _isCollided = true;

            SetColor(platform.GetColor());
        }
    }
    public void SetColor(Color color)
    {
        _meshRenderer.material.SetColor(Constants.Color, color);
        _meshRenderer.material.SetColor(Constants.EmissionColor, color);
    }

    private IEnumerator Counting()
    {
        yield return _waitForSeconds;

        gameObject.SetActive(false);

        _isCollided = false;

        SetColor(_defaultColor);
    }
}