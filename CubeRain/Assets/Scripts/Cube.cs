using System.Collections;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class Cube : MonoBehaviour
{
    [SerializeField] private Color _defaultColor;

    private MeshRenderer _meshRenderer;
    private Coroutine _currentCoroutine;
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
        _currentCoroutine = StartCoroutine(Counting());
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
        _meshRenderer.material.SetColor("_Color", color);
        _meshRenderer.material.SetColor("_EmissionColor", color);
    }

    private IEnumerator Counting()
    {
        yield return _waitForSeconds;

        gameObject.SetActive(false);

        _isCollided = false;

        SetColor(_defaultColor);
    }
}