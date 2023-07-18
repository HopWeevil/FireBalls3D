using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = Vector3.forward;
    }

    private void Update()
    {
        transform.Translate(_moveDirection * _bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out TowerElement towerElement))
        {
            towerElement.GetComponentInParent<Tower>().DecreaseSize();
            towerElement.Break();
        }
        Destroy(gameObject);
    }
}
