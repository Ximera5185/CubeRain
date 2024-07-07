using Assets.Scripts;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class Platform : MonoBehaviour
{
    [SerializeField] private ColorGenerator _colorGenerator;

    private MeshRenderer _meshRenderer;
    private WaitForSeconds _waitForSeconds;
    private float _time—olor—hange = 1f;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _waitForSeconds = new WaitForSeconds(_time—olor—hange);
    }

    private void Start()
    {
        StartCoroutine(Counting());
    }

    public Color GetColor()
    {
        return _meshRenderer.material.color;
    }

    private void SetColor(Color color)
    {
        _meshRenderer.material.SetColor(Constants.Color, color);
        _meshRenderer.material.SetColor(Constants.EmissionColor, color);
    }

    private IEnumerator Counting()
    {
        while (enabled)
        {
            Color color = _colorGenerator.GetRandomCustomHDRColor().color;

            SetColor(color);

            yield return _waitForSeconds;
        }
    }
}