using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private Transform _buildPoint;
    [SerializeField] private float _elementSpacing;

    private TowerTemplate _towerTemplate;
    private List<TowerElement> _towerElements;
    private Transform _currentBuildPoint;

    public List<TowerElement> Build(int towerSize, TowerTemplate towerTemplate)
    {
        _towerTemplate = towerTemplate;
        _currentBuildPoint = _buildPoint;
        _towerElements = new List<TowerElement>();

        for (int i = 0; i < towerSize; i++)
        {
            TowerElement towerElement = BuildTowerElement();
            towerElement.transform.localScale = GetElementScale(i);
            _currentBuildPoint = towerElement.transform;
            _towerElements.Add(towerElement);
        }

        return _towerElements;
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
        return Quaternion.Euler(new Vector2(0, _towerElements.Count * _towerTemplate.AdditionalAngle));
    }

    private Vector3 GetElementScale(int currentTowerSize)
    {
        Vector3 elementScale = _towerTemplate.TowerElement.transform.localScale;
        if ((currentTowerSize & 1) == 0)
        {
            return elementScale + new Vector3(_towerTemplate.ScaleX, 0, _towerTemplate.ScaleZ);
        }
        else
        {
            return elementScale;
        }
    }
}