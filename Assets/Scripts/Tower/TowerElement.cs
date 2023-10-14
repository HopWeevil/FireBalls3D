using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MeshRenderer))]
public class TowerElement : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private MeshFilter _meshFilter;
    [SerializeField] private BreakEffect _breakEffect;
    public Vector3 MeshBounds => _meshRenderer.bounds.size;

    public void SetColor(Color color)
    {
        _meshRenderer.material.color = color;
    }

    public void ApplyScaleModifier(TowerCreatorPatten towerStage)
    {
        transform.localScale = transform.localScale + new Vector3(towerStage.ScaleX, 0, towerStage.ScaleZ);
    }

    public void Break()
    {
        Instantiate(_breakEffect).Play(transform, _meshRenderer.material.color, _meshFilter.sharedMesh);
        Destroy(gameObject);
    }
}