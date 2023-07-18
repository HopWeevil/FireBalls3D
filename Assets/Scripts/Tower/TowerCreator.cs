using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    [SerializeField] private Transform _buildPoint;
    [SerializeField] private float _elementSpacing;

    private TowerTemplate _towerTemplate;
    private Transform _currentBuildPoint;
    private int _currentPatternIndex;
    private float _currentAngle;

    public float ElementSpacing => _elementSpacing;

    public void Build(int towerSize, TowerTemplate towerTemplate)
    {
        _towerTemplate = towerTemplate;
        _currentBuildPoint = _buildPoint;

        for (int i = 0; i < towerSize; i++)
        {
            TowerCreatorPatten towerPattern = GetPattern();
            TowerElement towerElement = BuildTowerElement();
            towerElement.ApplyScaleModifier(towerPattern);
            towerElement.SetColor(towerPattern.Color);
            _currentBuildPoint = towerElement.transform;
            _currentAngle += _towerTemplate.AdditionalAngle;
        }
    }

    private TowerElement BuildTowerElement()
    {
        return Instantiate(_towerTemplate.TowerElement, GetBuildPoint(), GetElementRotation(), _buildPoint);
    }

    private Vector3 GetBuildPoint()
    {
        return new Vector3(_buildPoint.position.x, _currentBuildPoint.position.y + _towerTemplate.TowerElement.MeshBounds.y + _elementSpacing, _buildPoint.position.z);
    }

    private Quaternion GetElementRotation()
    {
        return Quaternion.Euler(new Vector2(0, _currentAngle));
    }

    private TowerCreatorPatten GetPattern()
    {
        TowerCreatorPatten patten = _towerTemplate.TowerCreatorPattern[_currentPatternIndex];
        _currentPatternIndex = (_currentPatternIndex + 1) % _towerTemplate.TowerCreatorPattern.Length;
        return patten;
    }
}