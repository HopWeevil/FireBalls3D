using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TowerBuilder))]
[RequireComponent(typeof(TowerColorizer))]
[RequireComponent(typeof(TowerRotator))]
public class Tower : MonoBehaviour
{
    [SerializeField] private int _towerSize;
    [SerializeField] private TowerTemplate[] _towerTemplates;

    private TowerTemplate _towerTemplate;
    private TowerBuilder _towerBuilder;
    private TowerColorizer _towerColorizer;
    private TowerRotator _towerRotator;
    private List<TowerElement> _towerElements;

    private void Start()
    {
        _towerBuilder = GetComponent<TowerBuilder>();
        _towerColorizer = GetComponent<TowerColorizer>();
        _towerRotator = GetComponent<TowerRotator>();
        Initialize(); 
    }

    private void Initialize()
    {
        _towerTemplate = _towerTemplates[Random.Range(0, _towerTemplates.Length)];
        _towerElements = _towerBuilder.Build(_towerSize, _towerTemplate);
        _towerColorizer.Colorize(_towerElements, _towerTemplate);
    }

    private void Update()
    {
        _towerRotator.Rotate();
    }
}