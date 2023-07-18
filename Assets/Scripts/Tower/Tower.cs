using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TowerCreator))]
[RequireComponent(typeof(TowerRotator))]
public class Tower : MonoBehaviour
{
    [SerializeField] private int _size;
    [SerializeField] private TowerTemplate[] _towerTemplates;

    private TowerTemplate _towerTemplate;
    private TowerCreator _towerCreator;
    private TowerRotator _towerRotator;
    private int _currentSize;

    private void Update()
    {
        _towerRotator.Rotate();
    }

    private void Start()
    {
        _currentSize = _size;
        _towerCreator = GetComponent<TowerCreator>();
        _towerRotator = GetComponent<TowerRotator>();
        Initialize(); 
    }

    private void Initialize()
    {
        _towerTemplate = _towerTemplates[Random.Range(0, _towerTemplates.Length)];
        _towerCreator.Build(_size, _towerTemplate);
    }

    public void DecreaseSize()
    {
        _currentSize--;
        MoveDown();
    }

    private void MoveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (_towerTemplate.TowerElement.MeshBounds.y + _towerCreator.ElementSpacing), transform.position.z);
    }
}