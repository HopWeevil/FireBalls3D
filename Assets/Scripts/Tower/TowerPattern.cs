using UnityEngine;

[System.Serializable]
public class TowerPatten
{
    [SerializeField] private Color _color;
    [SerializeField] private float _scaleX;
    [SerializeField] private float _scaleZ;

    public Color Color => _color;
    public float ScaleX => _scaleX;
    public float ScaleZ => _scaleZ;
}
