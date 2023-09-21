using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _bulletPoint;
    [SerializeField] private Projectile _bulletPrefab;
    [SerializeField] private float _shootDelay;
    private float _timeAfterShoot;

    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_timeAfterShoot > _shootDelay)
            {
                Shoot();
                _timeAfterShoot = 0;
            }
        }
    }

    private void Shoot()
    {
        Instantiate(_bulletPrefab, _bulletPoint.position, Quaternion.identity);
    }
}