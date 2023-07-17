using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class TowerElement : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer; 
    public Vector3 MeshBounds => meshRenderer.bounds.size;

    public void SetColor(Color color)
    {
        meshRenderer.material.color = color;
    }
}