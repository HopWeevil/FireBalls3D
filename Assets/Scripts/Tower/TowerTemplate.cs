using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/NewTowerTemplate")]
public class TowerTemplate : ScriptableObject
{
    [SerializeField] private TowerElement _towerElement;
    [SerializeField] private float _additionalAngle;
    [SerializeField] private Color[] _colors;
    [SerializeField] private float _scaleX;
    [SerializeField] private float _scaleZ;

    public Color[] Colors => _colors;
    public TowerElement TowerElement => _towerElement;
    public float AdditionalAngle => _additionalAngle;
    public float ScaleX => _scaleX;
    public float ScaleZ => _scaleZ;
}