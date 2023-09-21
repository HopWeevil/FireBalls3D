using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstacleTemplates;
    [SerializeField] private Color[] _colors;
    [SerializeField] private Material _obstacleMaterial;

    private void Start()
    {
        _obstacleMaterial.color = _colors[Random.Range(0, _colors.Length)];
        Instantiate(_obstacleTemplates[Random.Range(0, _obstacleTemplates.Length)], transform);
    }
}
